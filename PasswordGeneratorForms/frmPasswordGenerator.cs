using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace PasswordGeneratorForms
{
    public partial class frmPasswordGenerator : Form
    {
        public frmPasswordGenerator()
        {
            InitializeComponent();
        }
        private static Random rndRandomGenerator = new Random();

        //An enum of the required character types
        private enum CharType
        {
            //Signifies a number from 1 to 9 inclusive
            Number,
            //Signifies a letter from a-z inclusive
            Lowercase,
            //Signifies a letter from A-Z inclusive
            Uppercase,
            //Signifies a letter from the SPECIAL_CHARS string
            Special
        }

        //The required length of the password
        private const int PASSWORD_LENGTH = 6;

        //The required length of the password
        private const int PASSWORD_REQUIREMENTS_LENGTH = 4;

        //All the special characters allowed in the password
        private const string SPECIAL_CHARS = "!@#$%";
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string strPassword = "";
            //Generate all 4 types
            for (int j = 0; j < PASSWORD_REQUIREMENTS_LENGTH; j++)
                strPassword += GenerateRandomCharByType((CharType)j);

            //Generate 2 more random letters
            for (int j = 0; j < PASSWORD_LENGTH - PASSWORD_REQUIREMENTS_LENGTH; j++)
            {
                strPassword += GenerateRandomCharByType((CharType)rndRandomGenerator.Next(0, 4));
            }

            //Randomize the order of all the alphanumeric characters in the password
            strPassword = string.Join("", strPassword.OrderBy(x => rndRandomGenerator.Next(strPassword.Length)));
            //Show the password to the user
            lblPassword.Text = "Your password is: " + strPassword;
        }

        //This function takes in the type of the character that you want and returns a random character from that pool of characters
        private static char GenerateRandomCharByType(CharType type)
        {
            switch (type)
            {
                case CharType.Number:
                    return rndRandomGenerator.Next(1, 10).ToString()[0];
                case CharType.Lowercase:
                    return (char)('a' + rndRandomGenerator.Next(0, 26));
                case CharType.Uppercase:
                    return (char)('A' + rndRandomGenerator.Next(0, 26));
                case CharType.Special:
                    return SPECIAL_CHARS[rndRandomGenerator.Next(SPECIAL_CHARS.Length)];
                default:
                    //This should never happen, but just in case.
                    return ' ';
            }
        }

        private void lblPassword_Click(object sender, EventArgs e)
        {
            //Copy the password to the clipboard. The password starts a space after the colon in the lblPassword label, so I used the substring function to fix that.
            Clipboard.SetText(lblPassword.Text.Substring(lblPassword.Text.IndexOf(':') + 1));
        }
    }
}
