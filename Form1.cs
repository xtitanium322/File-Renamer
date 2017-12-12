using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input; // for key events

namespace FileRenamer
{
    /// <summary>
    /// this program allows user to select a folder on their computer and rename all the files using a base name and indexing sequence
    /// good for creating uniform file names for related pictures 
    /// </summary>
    public partial class FileRenamer : Form
    {
        FolderBrowserDialog folder; // selected folder
        DirectoryInfo filedir;      // file directory object
        private bool mouseDown;     // mousedown flag for custom window movement
        private Point lastLocation; // window location (when user is dragging the wndow)

        /// <summary>
        /// Constructs the File Renamer Form object
        /// </summary>
        public FileRenamer()
        {
            InitializeComponent();
            folder = new FolderBrowserDialog();                 // folder with files to be renamed
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // turn off window resizing
        }

        /// <summary>
        /// Opens the folder in which desired files are located
        /// </summary>
        /// <param name="sender"> reference to the object that raised the event</param>
        /// <param name="e"> event specific object with relevant parameters </param>
        private void buttonOpenFolder_Click(object sender, EventArgs e)
        {
            ChooseFolder(); // open a folder selection window and assign the path to label when its done
        }

        /// <summary>
        /// Function to select a folder on user's computer
        /// Also generates a list of filenames in the selected folder
        /// </summary>
        private void ChooseFolder()
        {
            if (folder.ShowDialog() == DialogResult.OK)
            {
                // clear the box if it had values before
                listBox1.Items.Clear();
                // assign the path to label
                labelFolderPath.Text = folder.SelectedPath; 
                // reset progress bar
                progressBarOperationProgress.Value = 0; 
                labelProgressValue.Text = "0 %";
                // access directory selected by the user
                filedir = new DirectoryInfo(labelFolderPath.Text);

                ListFilenames();
                checkFormReadiness(); // check if the button should be enabled and check if the name is good
            }
            // change the name of the folder select button
            buttonOpenFolder.Text = "Change Folder";
        }

        /// <summary>
        /// Lists all the files in the selected folder inside a listbox
        /// </summary>
        private void ListFilenames()
        {
            // list filenames that exist in the selected directory
            try
            {
                if (filedir.Exists)
                {
                    foreach (FileInfo fi in filedir.GetFiles())
                    {
                        listBox1.Items.Add(fi.Name);
                    }
                }
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine("The process failed: {0}", e.ToString());
            }
            finally
            {
            }  
        }

        /// <summary>
        /// This button starts the process of renaming files. Check that there is a new name in the proper box : textBox1
        /// </summary>
        /// <param name="sender"> reference to the object that raised the event</param>
        /// <param name="e"> event specific object with relevant parameters </param>
        private void button1_Click(object sender, EventArgs e)
        {
            // failsafe - make sure there is a new filename available
            if(textBox1.Text.Length > 0)
            {
                // prepare variables
                string filename_base = textBox1.Text + '_';
                int index = (int)numericUpDown1.Value;              
                string[] picture_extensions = { ".jpg", ".png", ".gif", ".jpeg", ".bmp" };
                // start renaming process
                try
                {
                    if (filedir.Exists)
                    {
                        // prepare variables
                        int file_count = filedir.GetFiles().Count();
                        int processed_file_count = 0;
                        int progress_percent = 0;
                        progressBarOperationProgress.Step = (1/file_count)*100; // calculate 1 progress step
                        // clear file list contents
                        listBox1.Items.Clear();
                        // rename the files
                        foreach (FileInfo fi in filedir.GetFiles())
                        {
                            string extension = Path.GetExtension(fi.FullName); // isolate fiule extension
                            string newfilename = filename_base + index + extension;

                            // rename files
                            if (radioButtonAllFiles.Checked)
                            {
                                // any file can be renamed
                                System.IO.File.Move(fi.FullName, filedir.FullName + '\\' + newfilename); // construct a path
                                index++;
                            }
                            else if(radioButtonPictures.Checked)
                            {
                                // check for known picture file extensions
                                if(picture_extensions.Contains(extension.ToLower()))
                                {
                                    System.IO.File.Move(fi.FullName, filedir.FullName + '\\' + newfilename); // construct a path
                                    index++;
                                }
                            }

                            // update progress bar value
                            processed_file_count++;
                            progress_percent = (processed_file_count / file_count)*100; // percent value converted to int in the range 0-100
                            progressBarOperationProgress.Value = progress_percent; // assign the value to progress bar  
                            labelProgressValue.Text = progressBarOperationProgress.Value + " %";
                            progressBarOperationProgress.PerformStep();
                        }

                        ListFilenames();
                    }
                }
                catch (Exception exc)
                {
                    System.Diagnostics.Debug.WriteLine("The process failed: {0}", exc.ToString());
                }
                finally
                {
                    textBox1.Clear();
                }  
            }
        }

        /// <summary>
        /// On text change - enable the rename button based on the information inside the textbox
        /// </summary>
        /// <param name="sender"> reference to the object that raised the event</param>
        /// <param name="e"> event specific object with relevant parameters </param>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            checkFormReadiness();
        }

        /// <summary>
        /// Allows checking new filename at all times not just when text field changes from empty to filled
        /// </summary>
        /// <param name="sender"> reference to the object that raised the event</param>
        /// <param name="e"> event specific object with relevant parameters </param>
        private void textBox1_KeyPress(object sender, KeyEventArgs e)
        {
           checkFormReadiness(); // check text field when text exists and a key has been pressed
        }
        /// <summary>
        /// This function checks if the program is ready to rename files
        /// </summary>
        private void checkFormReadiness()
        {
            try
            {
                if (textBox1.Text.Length > 0)
                {
                    // check user entered filename
                    // if there are spaces or special characters - disable the button and show a warning message
                    if (hasSpecialCharacters(textBox1.Text))
                    {
                        button1.Enabled = false;
                        button1.BackColor = Color.Gray;
                        button1.ForeColor = Color.LightGray;
                        labelNewFilename.ForeColor = Color.OrangeRed; // highlight the label to show error
                        labelMessage.Text = "new filename can't contain spaces or special characters";
                    }
                    else
                    {
                        labelNewFilename.ForeColor = Color.White; // return the label back to original color
                        labelMessage.Text = "";
                        // enable the button only if directory has been selected
                        if (filedir != null && filedir.Exists)
                        {
                            button1.Enabled = true;
                            button1.BackColor = Color.DeepSkyBlue;
                            button1.ForeColor = Color.Black;
                        }
                    }
                }
                else
                {
                    button1.Enabled = false;
                    button1.BackColor = Color.Gray;
                    button1.ForeColor = Color.LightGray;
                    labelNewFilename.ForeColor = Color.White;
                    labelMessage.Text = "";
                }
            }
            catch(NullReferenceException e)
            {
                System.Diagnostics.Debug.WriteLine("The process failed (likely missing folder ref): {0}", e.ToString());
            }
        }

        /// <summary>
        /// Reset the text field on the click of this button
        /// </summary>
        /// <param name="sender"> reference to the object that raised the event</param>
        /// <param name="e"> event specific object with relevant parameters </param>
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            checkFormReadiness();
        } 

        /// <summary>
        /// Function that checks for presence of special characters (illegal in the filenames on windows)
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        private bool hasSpecialCharacters(string s)
        {
            // regular expression allows for lowercase, uppercase letters, numbers and underscores
            return (!Regex.IsMatch(s, @"^[a-zA-Z0-9_]+$"));
        }

        /// <summary>
        /// Exits the program
        /// </summary>
        /// <param name="sender"> reference to the object that raised the event</param>
        /// <param name="e"> event specific object with relevant parameters </param>
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

// moving borderless window

        /// <summary>
        /// Event delegate for mouse button down 
        /// </summary>
        /// <param name="sender"> reference to the object that raised the event</param>
        /// <param name="e"> event specific object with relevant parameters - in this case - mouse values </param>
        private void FileRenamer_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        /// <summary>
        /// Event delegate for mouse movement
        /// </summary>
        /// <param name="sender"> reference to the object that raised the event</param>
        /// <param name="e"> event specific object with relevant parameters - in this case - mouse values </param>
        private void FileRenamer_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        /// <summary>
        /// Event delegate for mouse button up
        /// </summary>
        /// <param name="sender"> reference to the object that raised the event</param>
        /// <param name="e"> event specific object with relevant parameters - in this case - mouse values </param>
        private void FileRenamer_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
