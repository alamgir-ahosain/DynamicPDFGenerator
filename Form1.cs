
using System.Data;
using Microsoft.Data.SqlClient;

using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.IO;


using iText.Kernel.Pdf;
using iText.Layout;
using iText.Html2pdf;
using System.Drawing;




namespace pdfDesign
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        // Declare a variable to hold the selected image file path
        private string imageFilePath = string.Empty;

        private void add_Click(object sender, EventArgs e)
        {

            // Check if an image has been selected
            if (string.IsNullOrEmpty(imageFilePath))
            {
                MessageBox.Show("Please browse and select an image before adding the record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method if no image is selected
            }

            string saveDirectory = @"E:\typeOFlanguage\c#\ExportToPDF\"; // Directory to save the image
            string fileExtension = Path.GetExtension(imageFilePath); // Get the file extension (e.g., .jpg, .png)
            string fileName = roll.Text + fileExtension; // Name the file as roll.format
            string fullPath = Path.Combine(saveDirectory, fileName); // Combine directory and file name to get the full path

            try
            {
                // If the image path is not empty, save the image to the specified directory
                if (!string.IsNullOrEmpty(imageFilePath))
                {
                    // Check if the directory exists; if not, create it
                    if (!Directory.Exists(saveDirectory))
                    {
                        Directory.CreateDirectory(saveDirectory);
                    }

                    // Copy the image to the target directory with the new file name
                    File.Copy(imageFilePath, fullPath, true); // true to overwrite if file already exists
                }

                using (SqlConnection con = new SqlConnection("Data Source=LAPTOPJK\\SQLEXPRESS05;Database=PhoneBookDB;Integrated Security=True;TrustServerCertificate=True"))
                {
                    con.Open();

                    // Insert SQL command to save the file path in the database
                    SqlCommand cmd = new SqlCommand("INSERT INTO info (" +
                        "[unit], [roll], [cname], [fname], [mname], [bill], [amount], [status], [cse], [ict], [textile], [photo]) " +
                        "VALUES (@unit, @roll, @cname, @fname, @mname, @bill, @amount, @status, @cse, @ict, @textile, @photo)", con);

                    // Add parameters
                    cmd.Parameters.AddWithValue("@unit", unit.Text);
                    cmd.Parameters.AddWithValue("@roll", roll.Text);
                    cmd.Parameters.AddWithValue("@cname", cname.Text);
                    cmd.Parameters.AddWithValue("@fname", fname.Text);
                    cmd.Parameters.AddWithValue("@mname", mname.Text);
                    cmd.Parameters.AddWithValue("@bill", bill.Text);
                    cmd.Parameters.AddWithValue("@amount", amount.Text);
                    cmd.Parameters.AddWithValue("@status", comStatus.Text);
                    cmd.Parameters.AddWithValue("@cse", comboCSE.Text);
                    cmd.Parameters.AddWithValue("@ict", comboICT.Text);
                    cmd.Parameters.AddWithValue("@textile", comboTextile.Text);

                    // Store the file path in the database (e.g., E:\typeOFlanguage\c#\ExportToPDF\CE21001.jpg)
                    cmd.Parameters.AddWithValue("@photo", fullPath);

                    // Execute the SQL command
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }







        private void pdf_Click(object sender, EventArgs e)
        {


            string rollInput = @roll.Text;
            string baseDirectory = @"E:\typeOFlanguage\c#\ExportToPDF\";  // Base directory where photos are saved
            string photoPath = Path.Combine(baseDirectory, rollInput + ".jpg");  // Construct the full file path

            // Check if the photo path is valid
            if (string.IsNullOrEmpty(photoPath))
            {
                MessageBox.Show("Photo path is empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!File.Exists(photoPath))
            {
                MessageBox.Show($"Photo file does not exist at: {photoPath}", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

          





            // Create and configure the SaveFileDialog
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf"; // Filter for PDF files
            saveFileDialog.Title = "Save PDF As";

            // Show the dialog and check if the user selected a file
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string pdfFilePath = saveFileDialog.FileName; // Get the selected file path

                // Prepare HTML content with CSS styling
                string htmlContent = @"
   <html>
        <head>
            <meta charset='UTF-8'>
            <title>Acknowledgment Slip</title>
            <style>
                /* General Styles */
                body {
                    font-family: Arial, sans-serif;
                    margin: 0;
                    padding: 0;
                    background-color: #ffffff;
                }

                .container {
                    width: 70%; /* Increase width for better presentation */
                    margin: 40px auto;
                    background: #ffffff;
                   
                }

                header {
                    text-align: center;
                    margin-bottom: 20px;
                }

                header h4, header h5, header h6, header h7 {
                    margin: 5px 0;
                    font-weight: normal;
                }
                    


                header img {
                    width: 50px; /* Smaller logo size */
                    height: 50px;
                    margin-bottom: 10px;
                }

                                .unit-section {
                    display: flex;
                    justify-content: space-between;  /* Ensures space between the items */
                    margin:10 px 0;
                    font-size: 0.9em;
                    
                }

                .unit-section span {
                    flex: 1;  /* Allows each span to take equal space */
                    text-align: center;  /* Centers the text within the available space */
}

                .candidate-info {
                    display: flex;
                    justify-content: space-between;
                    margin: 20px 0;
                }

                .candidate-details {
                    width: 60%;
                    font-size: 0.9em;
                }

                .candidate-photo img {
                    width: 100px;
                    height: 100px;
                    border: 1px solid #ccc;
                    border-radius: 4px;
                }

                .bill-section table, .subject-choice table {
                    width: 100%;
                    border-collapse: collapse;
                    margin: 15px 0;
                    font-size: 0.9em;
                }

                .bill-section table th, .bill-section table td,
                .subject-choice table th, .subject-choice table td {
                    border: 1px solid #ccc;
                    padding: 8px;
                    text-align: center;
                }

                .payment-instruction {
                    margin: 15px 0;
                    padding: 10px;
                    text-align: center;
                    border: 1px solid #0073e6;
                    background-color: #f1f8ff;
                    font-size: 0.9em;
                    border-radius: 4px;
                    font-weight: bold;
                }

                .footer {
                    margin-top: 15px;
                    font-size: 0.85em;
                    text-align: right;
                    color: #666;
                }

                .footer p {
                    margin: 5px 0;
                    line-height: 1.4;
                }
            </style>
        </head>
        <body>
            <div class='container'>
                <header>
                    <img src='E:\typeOFlanguage\c#\mbstu.jpg' alt='Logo'>
                    <h5>MAWLANA BHASHANI SCIENCE AND TECHNOLOGY UNIVERSITY</h5>
                    <h4><u>Undergraduate Admission 2021-22</u></h4>
                    <h5 style='font-weight: bold'>Acknowledgment Slip</h5>
                </header>

                <div class='unit-section'>
                    <span>UNIT: <strong>" + @unit.Text + @"</strong></span>
                    <span>GST ROLL: <strong>" + @roll.Text + @"</strong></span>
                </div>

                <div class='candidate-info'>
                    <div class='candidate-details'>
                        <p><strong>Candidate:</strong> " + @cname.Text + @"</p>
                        <p><strong>Father:</strong> " + @fname.Text + @"</p>
                        <p><strong>Mother:</strong> " + @mname.Text + @"</p>
                    </div>
                    <div class='candidate-photo'>
            
                <img src='" + photoPath + @"' alt='Candidate Photo' />


                    </div>
                </div>
                <div class='bill-section'>
                    <h4>Bill Details</h4>
                    <table>
                        <thead>
                            <tr>
                          <th></th>
                          <th>Bill No.</th>
                          <th>Amount</th>
                          </tr>
                        </thead>
                        <tbody>
                            <tr>
                            <td>" + comStatus.Text + @"</td>
                            <td>" + bill.Text + @"</td>
                            <td>" + amount.Text + @"</td>
                            </tr>
                             
                        </tbody>
                    </table>
                </div>
                <div class='subject-choice'>
                    <h4>Subject Choice Order</h4>
                    <table>
                        <thead>
                            <tr>
                            <th>Subject</th>
                            <th>Choice</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                            <td>CSE</td>
                            <td>" + comboCSE.Text + @"</td>
                            </tr> 

                            <tr>
                            <td>ICT</td>
                            <td>" + comboICT.Text + @"</td>
                            </tr>

                            <tr>
                            <td>Textile</td>
                            <td>" + comboTextile.Text + @"</td>
                            </tr>

                            
                        </tbody>
                    </table>
                </div>
                <div class='payment-instruction'>
                    Pay your bill using DBBL Mobile banking (Rocket). Visit the 'Payment Instruction' page on the website.
                </div>
                <div class='footer'>
                    <p><strong>For system-related queries:</strong></p>
                    <p>MD. Name, PhD<br>Member of Technical Subcommittee, MBSTU<br>Mobile: +88-01727786600</p>
                </div>
            </div>
        </body>
        </html>
              



";

                // Create a MemoryStream to hold the PDF
                using (MemoryStream ms = new MemoryStream())
                {
                    // Convert HTML to PDF and write it to the MemoryStream
                    HtmlConverter.ConvertToPdf(htmlContent, ms);

                    // Save the PDF from MemoryStream to the chosen file path
                    File.WriteAllBytes(pdfFilePath, ms.ToArray());
                }

                MessageBox.Show("PDF created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }






        }

        private void SearchByRoll_Click(object sender, EventArgs e)
        {

            string rollInput = searchRoll.Text;

            if (string.IsNullOrWhiteSpace(rollInput))
            {
                MessageBox.Show("Please enter a roll number.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection con = new SqlConnection("Data Source=LAPTOPJK\\SQLEXPRESS05;Database=PhoneBookDB;Integrated Security=True;TrustServerCertificate=True"))
            {
                try
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM info WHERE [roll] = @roll", con);
                    cmd.Parameters.AddWithValue("@roll", rollInput);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read()) // Check if a record is found
                    {
                        unit.Text = reader["unit"].ToString();
                        roll.Text = reader["roll"].ToString();
                        cname.Text = reader["cname"].ToString();
                        fname.Text = reader["fname"].ToString();
                        mname.Text = reader["mname"].ToString();
                        bill.Text = reader["bill"].ToString();
                        amount.Text = reader["amount"].ToString();
                        comStatus.Text = reader["status"].ToString();
                        comboCSE.Text = reader["cse"].ToString();
                        comboICT.Text = reader["ict"].ToString();
                        comboTextile.Text = reader["textile"].ToString();

                        // Load photo from file path stored in the database and display in PictureBox
                        string photoPath = reader["photo"].ToString(); // Get the file path from database
                        if (!string.IsNullOrEmpty(photoPath) && File.Exists(photoPath))
                        {
                            pictureBox.Image = System.Drawing.Image.FromFile(photoPath); // Display image in PictureBox
                        }
                        else
                        {
                            pictureBox.Image = null; // If no photo found, clear the PictureBox
                        }
                    }
                    else
                    {
                        MessageBox.Show("No record found for the entered roll number.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearTextBoxes(); // Clear text boxes if no record is found
                        pictureBox.Image = null; // Clear PictureBox if no photo found
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }






        }


        private void ClearTextBoxes()
        {
            unit.Clear();
            roll.Clear();
            cname.Clear();
            fname.Clear();
            mname.Clear();
            bill.Clear();
            amount.Clear();
            comStatus.SelectedIndex = -1;
            comboCSE.SelectedIndex = -1;
            comboICT.SelectedIndex = -1;
            comboTextile.SelectedIndex = -1;
        }

        private void loadImageButton_Click(object sender, EventArgs e)
        {


            //OpenFileDialog openFileDialog = new OpenFileDialog();
            //openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif"; // Filter for image files

            //if (openFileDialog.ShowDialog() == DialogResult.OK)
            //{
            //    imageFilePath = openFileDialog.FileName;
            //    pictureBox.Image = System.Drawing.Image.FromFile(imageFilePath); // Display the selected image in PictureBox

            //    // Optionally, show a message or update UI to confirm the image is selected
            //    MessageBox.Show("Image selected: " + imageFilePath, "File Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else
            //{
            //    // If no image is selected, display a message
            //    MessageBox.Show("No image selected.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif"; // Filter for image files

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imageFilePath = openFileDialog.FileName;
                pictureBox.Image = System.Drawing.Image.FromFile(imageFilePath); // Display the selected image in PictureBox

                // No message box, just display the image and proceed
            }





        }





























    }

}
