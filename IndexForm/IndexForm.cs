using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace IndexForm
{
    public partial class IndexForm : Form
    {
        const string words_text_file = "words.txt";

        List<string> word_list = new List<string>();
        List<string> failed_attempts = new List<string>();

        Random random = new Random();

        string current_word = "";

        int attempts = 0;
        int guessed_words = 0;
        int score = 0;

        bool hint_used = false;

        public IndexForm()
        {
            InitializeComponent();
        }

        void IndexForm_Load(object sender, EventArgs e)
        {
            try
            {
                Get_All_Words();
                Generate_New_Word();
                Update_Labels();
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show($"Грешка: Файлът '{words_text_file}' не е намерен!\nУверете се, че се намира в папка bin\\Debug\\", "Липсващ файл", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Възникна грешка при зареждане: {ex.Message}", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Get_All_Words()
        {
            if (!File.Exists(words_text_file))
            {
                throw new FileNotFoundException();
            }

            using (StreamReader reader = new StreamReader(words_text_file))
            {
                while (!reader.EndOfStream)
                {
                    string word = reader.ReadLine()?.Trim();

                    if (!string.IsNullOrEmpty(word))
                    {
                        word_list.Add(word.ToLower());
                    }
                }
            }
        }

        void Generate_New_Word()
        {
            if (word_list.Count == 0)
            {
                MessageBox.Show("Успех! Няма повече останали думи!");
                current_word = "";
                label_scrambled_word.Text = "ПОБЕДА!";
                return;
            }

            int random_index = random.Next(0, word_list.Count);
            current_word = word_list[random_index];

            Reset_Game_Info();
        }

        void Reset_Game_Info()
        {
            attempts = 0;
            hint_used = false;
            failed_attempts.Clear();

            label_scrambled_word.Text = Scramble_Word(current_word);
            label_attempts_count.Text = attempts.ToString();
            label_hint.Text = "Hint: not used";

            textbox_input.Text = "";
            textbox_failed_attempts.Text = "";
        }

        string Scramble_Word(string word)
        {
            if (string.IsNullOrEmpty(word)) return "";

            char[] letters = word.ToCharArray();
            string scrambled_word = word;

            int maxAttempts = 10;
            int currentAttempt = 0;

            while (scrambled_word == word && currentAttempt < maxAttempts && word.Length > 1)
            {
                for (int i = 0; i < letters.Length; i++)
                {
                    int random_index = random.Next(0, letters.Length);

                    char old_letter = letters[i];
                    letters[i] = letters[random_index];
                    letters[random_index] = old_letter;
                }

                scrambled_word = new string(letters);
                currentAttempt++;
            }

            return scrambled_word;
        }

        void button_check_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(current_word)) return;

            Check_The_Word();
            Update_Labels();
        }

        void Check_The_Word()
        {
            string input = textbox_input.Text.Trim().ToLower();

            if (input == "")
            {
                MessageBox.Show("Please write a word first.");
                return;
            }

            if (input == current_word)
            {
                Successful_Attempt();
            }
            else
            {
                Unsuccessful_Attempt(input);
            }
        }

        void Successful_Attempt()
        {
            guessed_words++;

            if (hint_used == false)
            {
                score += 10;
            }
            else
            {
                score += 5;
            }

            word_list.Remove(current_word);
            MessageBox.Show("Correct!");
            Generate_New_Word();
        }

        void Unsuccessful_Attempt(string input)
        {
            attempts++;
            failed_attempts.Add(input);

            if (score > 0)
            {
                score--;
            }

            if (attempts > 9)
            {
                MessageBox.Show("Too many failed attempts. The word was: " + current_word);
                Generate_New_Word();
            }
        }

        void Update_Labels()
        {
            label_attempts_count.Text = attempts.ToString();
            label_guessed_words_count.Text = guessed_words.ToString();
            label_score_count.Text = score.ToString();

            textbox_failed_attempts.Text = string.Join(Environment.NewLine, failed_attempts);

            textbox_input.Text = "";
            textbox_input.Focus();
        }

        void button_skip_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(current_word)) return;

            MessageBox.Show("The skipped word was: " + current_word);
            Generate_New_Word();
            Update_Labels();
        }

        void button_hint_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(current_word)) return;

            if (hint_used == true)
            {
                MessageBox.Show("You already used the hint for this word.");
                return;
            }

            hint_used = true;
            string first_letter = current_word[0].ToString();
            label_hint.Text = "Hint: starts with " + first_letter;

            if (score > 1)
            {
                score -= 2;
            }

            Update_Labels();
        }

        void button_reset_Click(object sender, EventArgs e)
        {
            guessed_words = 0;
            score = 0;

            word_list.Clear();
            failed_attempts.Clear();

            try
            {
                Get_All_Words();
                Generate_New_Word();
                Update_Labels();
                MessageBox.Show("Game restarted.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Грешка при рестартиране: {ex.Message}");
            }
        }

        private void label_guessed_words_Click(object sender, EventArgs e) { }
    }
}