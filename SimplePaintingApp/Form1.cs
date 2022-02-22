namespace SimplePaintingApp
{
    public partial class frmMain : Form
    {
        //Boolean Attribute for controlling whether the painter should "draw".
        bool ShouldPaint { get; set; } = false;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_MouseDown(object sender, MouseEventArgs e)
        {
            //If the mouse is being pressed, enable painting mode.
            ShouldPaint = true;
        }

        private void frmMain_MouseUp(object sender, MouseEventArgs e)
        {
            //If the mouse is not being clicked, or the user releases the mouse button, disable painting mode.
            ShouldPaint = false;
        }

        private void frmMain_MouseMove(object sender, MouseEventArgs e)
        {
            //This code will draw a circle where the mouse pointer is present upon a change in a mouse's position
            //if the user is holding down the mouse button.
            if(ShouldPaint)
            {
                using (Graphics g = CreateGraphics())
                {
                    //Arguments:
                    //      SolidBrush Object that is used to define the fill color and type (in this case, a solid blue violet fill)
                    //      The x coordinate, which is the mouse's x coordinate.
                    //      The y coordinate, which is the mouse's y coordinate.
                    //      The width of the ellipses, which is 4.
                    //      The height of the ellipses, which is 4.

                    g.FillEllipse(new SolidBrush(Color.BlueViolet), e.X, e.Y, 4, 4);
                }
            }
        }
    }
}