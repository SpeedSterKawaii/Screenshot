Rectangle bounds = this.Bounds;
 using (Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height))
 {
    using (Graphics g = Graphics.FromImage(bitmap))
    {
        g.CopyFromScreen(new Point(bounds.Left,bounds.Top), Point.Empty, bounds.Size);
    }
    bitmap.Save("C://test.jpg", ImageFormat.Jpeg);//bmp is garbage like krnl :)
 }
