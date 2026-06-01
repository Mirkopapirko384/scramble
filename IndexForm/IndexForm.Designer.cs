using System;
using System.Windows.Forms;
using System.Drawing;

namespace IndexForm
{
    partial class IndexForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            label_title = new Label();
            label_hint = new Label();
            label_attempts = new Label();
            label_attempts_count = new Label();
            label_guessed_words = new Label();
            label_guessed_words_count = new Label();
            label_score = new Label();
            label_score_count = new Label();
            label_failed_attempts = new Label();
            textbox_input = new TextBox();
            textbox_failed_attempts = new TextBox();
            button_check = new Button();
            button_skip = new Button();
            button_hint = new Button();
            button_reset = new Button();
            sep2 = new Panel();
            sep3 = new Panel();
            label_scrambled_word = new Label();
            SuspendLayout();
            // 
            // label_title
            // 
            label_title.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_title.ForeColor = Color.FromArgb(241, 245, 249);
            label_title.Location = new Point(33, 10);
            label_title.Name = "label_title";
            label_title.Size = new Size(478, 64);
            label_title.TabIndex = 0;
            label_title.Text = "Word Scramble";
            // 
            // label_hint
            // 
            label_hint.Font = new Font("Segoe UI", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label_hint.ForeColor = Color.FromArgb(251, 191, 36);
            label_hint.Location = new Point(20, 162);
            label_hint.Name = "label_hint";
            label_hint.Size = new Size(300, 25);
            label_hint.TabIndex = 8;
            label_hint.Text = "Hint: not used";
            // 
            // label_attempts
            // 
            label_attempts.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_attempts.ForeColor = Color.FromArgb(148, 163, 184);
            label_attempts.Location = new Point(20, 254);
            label_attempts.Name = "label_attempts";
            label_attempts.Size = new Size(158, 48);
            label_attempts.TabIndex = 14;
            label_attempts.Text = "Attempts:";
            // 
            // label_attempts_count
            // 
            label_attempts_count.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_attempts_count.ForeColor = Color.FromArgb(248, 113, 113);
            label_attempts_count.Location = new Point(184, 252);
            label_attempts_count.Name = "label_attempts_count";
            label_attempts_count.Size = new Size(33, 39);
            label_attempts_count.TabIndex = 15;
            label_attempts_count.Text = "0";
            // 
            // label_guessed_words
            // 
            label_guessed_words.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label_guessed_words.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_guessed_words.ForeColor = Color.FromArgb(148, 163, 184);
            label_guessed_words.Location = new Point(843, 15);
            label_guessed_words.Name = "label_guessed_words";
            label_guessed_words.Size = new Size(141, 38);
            label_guessed_words.TabIndex = 1;
            label_guessed_words.Text = "Guessed:";
            label_guessed_words.Click += label_guessed_words_Click;
            // 
            // label_guessed_words_count
            // 
            label_guessed_words_count.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label_guessed_words_count.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_guessed_words_count.ForeColor = Color.FromArgb(34, 197, 94);
            label_guessed_words_count.Location = new Point(909, 50);
            label_guessed_words_count.Name = "label_guessed_words_count";
            label_guessed_words_count.Size = new Size(40, 42);
            label_guessed_words_count.TabIndex = 2;
            label_guessed_words_count.Text = "0";
            // 
            // label_score
            // 
            label_score.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label_score.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_score.ForeColor = Color.FromArgb(148, 163, 184);
            label_score.Location = new Point(1014, 15);
            label_score.Name = "label_score";
            label_score.Size = new Size(112, 38);
            label_score.TabIndex = 3;
            label_score.Text = "Score:";
            // 
            // label_score_count
            // 
            label_score_count.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label_score_count.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_score_count.ForeColor = Color.FromArgb(245, 158, 11);
            label_score_count.Location = new Point(1064, 50);
            label_score_count.Name = "label_score_count";
            label_score_count.Size = new Size(55, 39);
            label_score_count.TabIndex = 4;
            label_score_count.Text = "0";
            // 
            // label_failed_attempts
            // 
            label_failed_attempts.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_failed_attempts.ForeColor = Color.FromArgb(148, 163, 184);
            label_failed_attempts.Location = new Point(12, 302);
            label_failed_attempts.Name = "label_failed_attempts";
            label_failed_attempts.Size = new Size(166, 35);
            label_failed_attempts.TabIndex = 16;
            label_failed_attempts.Text = "Wrong guesses:";
            // 
            // textbox_input
            // 
            textbox_input.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_input.BackColor = Color.FromArgb(30, 41, 59);
            textbox_input.BorderStyle = BorderStyle.FixedSingle;
            textbox_input.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textbox_input.ForeColor = Color.White;
            textbox_input.Location = new Point(20, 196);
            textbox_input.Name = "textbox_input";
            textbox_input.Size = new Size(733, 39);
            textbox_input.TabIndex = 1;
            // 
            // textbox_failed_attempts
            // 
            textbox_failed_attempts.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_failed_attempts.BackColor = Color.FromArgb(30, 41, 59);
            textbox_failed_attempts.BorderStyle = BorderStyle.FixedSingle;
            textbox_failed_attempts.Font = new Font("Segoe UI", 10F);
            textbox_failed_attempts.ForeColor = Color.FromArgb(226, 232, 240);
            textbox_failed_attempts.Location = new Point(3, 340);
            textbox_failed_attempts.Multiline = true;
            textbox_failed_attempts.Name = "textbox_failed_attempts";
            textbox_failed_attempts.ReadOnly = true;
            textbox_failed_attempts.ScrollBars = ScrollBars.Vertical;
            textbox_failed_attempts.Size = new Size(1099, 322);
            textbox_failed_attempts.TabIndex = 2;
            textbox_failed_attempts.TabStop = false;
            // 
            // button_check
            // 
            button_check.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_check.BackColor = Color.FromArgb(16, 185, 129);
            button_check.FlatAppearance.BorderSize = 0;
            button_check.FlatStyle = FlatStyle.Flat;
            button_check.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_check.ForeColor = Color.White;
            button_check.Location = new Point(909, 116);
            button_check.Name = "button_check";
            button_check.Size = new Size(172, 47);
            button_check.TabIndex = 10;
            button_check.Text = "Check";
            button_check.UseVisualStyleBackColor = false;
            button_check.Click += button_check_Click;
            // 
            // button_skip
            // 
            button_skip.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_skip.BackColor = Color.FromArgb(100, 116, 139);
            button_skip.FlatAppearance.BorderSize = 0;
            button_skip.FlatStyle = FlatStyle.Flat;
            button_skip.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_skip.ForeColor = Color.White;
            button_skip.Location = new Point(909, 189);
            button_skip.Name = "button_skip";
            button_skip.Size = new Size(172, 42);
            button_skip.TabIndex = 11;
            button_skip.Text = "Skip";
            button_skip.UseVisualStyleBackColor = false;
            button_skip.Click += button_skip_Click;
            // 
            // button_hint
            // 
            button_hint.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_hint.BackColor = Color.FromArgb(139, 92, 246);
            button_hint.FlatAppearance.BorderSize = 0;
            button_hint.FlatStyle = FlatStyle.Flat;
            button_hint.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_hint.ForeColor = Color.White;
            button_hint.Location = new Point(909, 256);
            button_hint.Name = "button_hint";
            button_hint.Size = new Size(172, 46);
            button_hint.TabIndex = 12;
            button_hint.Text = "Hint";
            button_hint.UseVisualStyleBackColor = false;
            button_hint.Click += button_hint_Click;
            // 
            // button_reset
            // 
            button_reset.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_reset.BackColor = Color.FromArgb(239, 68, 68);
            button_reset.FlatAppearance.BorderSize = 0;
            button_reset.FlatStyle = FlatStyle.Flat;
            button_reset.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_reset.ForeColor = Color.White;
            button_reset.Location = new Point(986, 689);
            button_reset.Name = "button_reset";
            button_reset.Size = new Size(120, 42);
            button_reset.TabIndex = 17;
            button_reset.Text = "Reset Game";
            button_reset.UseVisualStyleBackColor = false;
            button_reset.Click += button_reset_Click;
            // 
            // sep2
            // 
            sep2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            sep2.BackColor = Color.FromArgb(51, 65, 85);
            sep2.Location = new Point(20, 186);
            sep2.Name = "sep2";
            sep2.Size = new Size(1099, 1);
            sep2.TabIndex = 9;
            // 
            // sep3
            // 
            sep3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            sep3.BackColor = Color.FromArgb(51, 65, 85);
            sep3.Location = new Point(20, 244);
            sep3.Name = "sep3";
            sep3.Size = new Size(1099, 1);
            sep3.TabIndex = 13;
            // 
            // label_scrambled_word
            // 
            label_scrambled_word.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label_scrambled_word.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_scrambled_word.ForeColor = Color.FromArgb(56, 189, 248);
            label_scrambled_word.Location = new Point(12, 64);
            label_scrambled_word.Name = "label_scrambled_word";
            label_scrambled_word.Size = new Size(891, 99);
            label_scrambled_word.TabIndex = 7;
            label_scrambled_word.Text = "...";
            // 
            // IndexForm
            // 
            BackColor = Color.FromArgb(15, 23, 42);
            ClientSize = new Size(1138, 759);
            Controls.Add(label_title);
            Controls.Add(label_guessed_words);
            Controls.Add(label_guessed_words_count);
            Controls.Add(label_score);
            Controls.Add(label_score_count);
            Controls.Add(label_scrambled_word);
            Controls.Add(label_hint);
            Controls.Add(sep2);
            Controls.Add(textbox_input);
            Controls.Add(button_check);
            Controls.Add(button_skip);
            Controls.Add(button_hint);
            Controls.Add(sep3);
            Controls.Add(label_attempts);
            Controls.Add(label_attempts_count);
            Controls.Add(label_failed_attempts);
            Controls.Add(textbox_failed_attempts);
            Controls.Add(button_reset);
            Font = new Font("Segoe UI", 10F);
            MaximumSize = new Size(9000, 7000);
            MinimumSize = new Size(600, 560);
            Name = "IndexForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Word Scramble";
            Load += IndexForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label_title;
        private Label label_hint;
        private Label label_attempts;
        private Label label_attempts_count;
        private Label label_guessed_words;
        private Label label_guessed_words_count;
        private Label label_score;
        private Label label_score_count;
        private Label label_failed_attempts;
        private TextBox textbox_input;
        private TextBox textbox_failed_attempts;
        private Button button_check;
        private Button button_skip;
        private Button button_hint;
        private Button button_reset;
        private Panel sep2;
        private Panel sep3;
        private Label label_scrambled_word;
    }
}