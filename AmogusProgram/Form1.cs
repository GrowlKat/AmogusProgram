using System.Media;
using AmogusProgram.Properties;

namespace AmogusProgram
{
    /// <summary>
    /// The meme Form
    /// </summary>
    public partial class Form1 : Form
    {
        private bool play = true; // Play or Stop state
        private bool plus = false; // Rainbow mode state
        private int ms = 15; // Delay between frames
        private int frame = 0; // Current frame

        private static CancellationTokenSource spinCancellationToken = new(); // Token for spin task

        private readonly SoundPlayer player = new(); // Music player
        private readonly Bitmap[] rainbowImages; // Rainbow images array
        private readonly Bitmap[] amogusImages; // Normal images array

        public Form1()
        {
            InitializeComponent();

            // Initialize Rainbow and Normal images
            rainbowImages = new Bitmap[]
            {
                Resources.Rainbow1,
                Resources.Rainbow2,
                Resources.Rainbow3,
                Resources.Rainbow4,
                Resources.Rainbow5,
                Resources.Rainbow6,
                Resources.Rainbow7,
                Resources.Rainbow8
            };
            amogusImages = new Bitmap[]
            {
                Resources.Amogus1,
                Resources.Amogus2,
                Resources.Amogus3,
                Resources.Amogus4,
                Resources.Amogus5,
                Resources.Amogus6,
                Resources.Amogus7,
                Resources.Amogus8
            };
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            button.Text = play ? "Stop" : "Play"; // Set button text depending on play state

            // Play music
            player.Stream = Resources.Music;
            player.Load();
            player.Play();

            await Spin(); // Start spin task
        }

        /// <summary>
        /// Starts spinning images
        /// </summary>
        private async Task Spin()
        {
            // While not cancelled, change image every ms milliseconds
            while (!spinCancellationToken.Token.IsCancellationRequested)
            {
                spinCancellationToken.Token.ThrowIfCancellationRequested();

                picture.Image = plus ? rainbowImages[frame] : amogusImages[frame]; // Set image
                await Task.Delay(ms); // Wait ms milliseconds
                frame = (frame == 7) ? 0 : frame + 1; // Change frame

                if (spinCancellationToken.Token.IsCancellationRequested) break; // If cancelled, break
            }
        }

        private async void button_Click(object sender, EventArgs e)
        {
            // If playing while this button is pressed, stop, else, play again
            if (play)
            {
                play = false;
                button.Text = "Play";
                player.Stop();
                spinCancellationToken.Cancel();
            }
            else
            {
                play = true;
                button.Text = "Stop";
                player.Play();
                spinCancellationToken = new CancellationTokenSource();
                await Spin();
            }
        }

        private void upgrade_Click(object sender, EventArgs e)
        {
            // Changes between Rainbow and Normal images
            plus = !plus;
            upgrade.Text = plus ? "Downgrande" : "Rave Mode";
        }

        private void lower_Click(object sender, EventArgs e)
        {
            // Increment delay between frames
            if (ms < 1000) ms += 5;
        }

        private void faster_Click(object sender, EventArgs e)
        {
            // Decrement delay between frames
            if (ms > 5) ms -= 5;
        }
    }
}