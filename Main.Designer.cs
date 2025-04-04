namespace bfm2;

partial class Main
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        label1 = new Label();
        button1 = new Button();
        textBox1 = new TextBox();
        label2 = new Label();
        label3 = new Label();
        dataGridView1 = new DataGridView();
        outsourcedBindingSource = new BindingSource(components);
        dataGridView2 = new DataGridView();
        productBindingSource = new BindingSource(components);
        button2 = new Button();
        button3 = new Button();
        button4 = new Button();
        button5 = new Button();
        button6 = new Button();
        button7 = new Button();
        textBox2 = new TextBox();
        button8 = new Button();
        productBindingSource1 = new BindingSource(components);
        button9 = new Button();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)outsourcedBindingSource).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
        ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
        ((System.ComponentModel.ISupportInitialize)productBindingSource1).BeginInit();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label1.Location = new Point(12, 9);
        label1.Name = "label1";
        label1.Size = new Size(271, 25);
        label1.TabIndex = 0;
        label1.Text = "Inventory Management System";
        // 
        // button1
        // 
        button1.Location = new Point(330, 78);
        button1.Name = "button1";
        button1.Size = new Size(75, 23);
        button1.TabIndex = 1;
        button1.Text = "Search";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // textBox1
        // 
        textBox1.Location = new Point(432, 78);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(235, 23);
        textBox1.TabIndex = 2;
        textBox1.TextChanged += textBox1_TextChanged;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label2.Location = new Point(37, 114);
        label2.Name = "label2";
        label2.Size = new Size(44, 21);
        label2.TabIndex = 3;
        label2.Text = "Parts";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label3.Location = new Point(726, 114);
        label3.Name = "label3";
        label3.Size = new Size(71, 21);
        label3.TabIndex = 4;
        label3.Text = "Products";
        // 
        // dataGridView1
        // 
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Location = new Point(37, 156);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.RowHeadersWidth = 51;
        dataGridView1.Size = new Size(655, 321);
        dataGridView1.TabIndex = 5;
        // 
        // outsourcedBindingSource
        // 
        outsourcedBindingSource.DataSource = typeof(Outsourced);
        // 
        // dataGridView2
        // 
        dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView2.Location = new Point(726, 156);
        dataGridView2.Name = "dataGridView2";
        dataGridView2.RowHeadersWidth = 51;
        dataGridView2.Size = new Size(659, 321);
        dataGridView2.TabIndex = 6;
        // 
        // productBindingSource
        // 
        productBindingSource.DataSource = typeof(Product);
        // 
        // button2
        // 
        button2.Location = new Point(414, 495);
        button2.Name = "button2";
        button2.Size = new Size(75, 23);
        button2.TabIndex = 7;
        button2.Text = "Add";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // button3
        // 
        button3.Location = new Point(495, 495);
        button3.Name = "button3";
        button3.Size = new Size(75, 23);
        button3.TabIndex = 8;
        button3.Text = "Modify";
        button3.UseVisualStyleBackColor = true;
        button3.Click += button3_Click;
        // 
        // button4
        // 
        button4.Location = new Point(576, 495);
        button4.Name = "button4";
        button4.Size = new Size(75, 23);
        button4.TabIndex = 9;
        button4.Text = "Delete";
        button4.UseVisualStyleBackColor = true;
        button4.Click += button4_Click;
        // 
        // button5
        // 
        button5.Location = new Point(1294, 495);
        button5.Name = "button5";
        button5.Size = new Size(75, 23);
        button5.TabIndex = 12;
        button5.Text = "Delete";
        button5.UseVisualStyleBackColor = true;
        button5.Click += button5_Click;
        // 
        // button6
        // 
        button6.Location = new Point(1213, 495);
        button6.Name = "button6";
        button6.Size = new Size(75, 23);
        button6.TabIndex = 11;
        button6.Text = "Modify";
        button6.UseVisualStyleBackColor = true;
        button6.Click += button6_Click;
        // 
        // button7
        // 
        button7.Location = new Point(1132, 495);
        button7.Name = "button7";
        button7.Size = new Size(75, 23);
        button7.TabIndex = 10;
        button7.Text = "Add";
        button7.UseVisualStyleBackColor = true;
        button7.Click += button7_Click;
        // 
        // textBox2
        // 
        textBox2.Location = new Point(1150, 78);
        textBox2.Name = "textBox2";
        textBox2.Size = new Size(235, 23);
        textBox2.TabIndex = 14;
        textBox2.TextChanged += textBox2_TextChanged;
        // 
        // button8
        // 
        button8.Location = new Point(1051, 77);
        button8.Name = "button8";
        button8.Size = new Size(75, 23);
        button8.TabIndex = 13;
        button8.Text = "Search";
        button8.UseVisualStyleBackColor = true;
        button8.Click += button8_Click;
        // 
        // productBindingSource1
        // 
        productBindingSource1.DataSource = typeof(Product);
        // 
        // button9
        // 
        button9.Location = new Point(1294, 661);
        button9.Name = "button9";
        button9.Size = new Size(75, 23);
        button9.TabIndex = 15;
        button9.Text = "Exit";
        button9.UseVisualStyleBackColor = true;
        button9.Click += button9_Click;
        // 
        // Main
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1425, 757);
        Controls.Add(button9);
        Controls.Add(textBox2);
        Controls.Add(button8);
        Controls.Add(button5);
        Controls.Add(button6);
        Controls.Add(button7);
        Controls.Add(button4);
        Controls.Add(button3);
        Controls.Add(button2);
        Controls.Add(dataGridView2);
        Controls.Add(dataGridView1);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(textBox1);
        Controls.Add(button1);
        Controls.Add(label1);
        Name = "Main";
        Text = "Main";
        Load += Main_Shown;
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ((System.ComponentModel.ISupportInitialize)outsourcedBindingSource).EndInit();
        ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
        ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
        ((System.ComponentModel.ISupportInitialize)productBindingSource1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private void Main_Shown1(object sender, EventArgs e)
    {
        throw new NotImplementedException();
    }

    #endregion

    private Label label1;
    private Button button1;
    private TextBox textBox1;
    private Label label2;
    private Label label3;
    private DataGridView dataGridView1;
    private DataGridView dataGridView2;
    private Button button2;
    private Button button3;
    private Button button4;
    private Button button5;
    private Button button6;
    private Button button7;
    private TextBox textBox2;
    private Button button8;
    private BindingSource productBindingSource;
    private BindingSource outsourcedBindingSource;
    private BindingSource productBindingSource1;
    private Button button9;
}
