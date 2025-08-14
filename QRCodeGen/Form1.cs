using QRCoder;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace QRCodeGen
{
    public partial class Form1 : Form
    {
        private QRCodeGenerator.ECCLevel eccLevel = QRCodeGenerator.ECCLevel.Default;
        private Bitmap? iconImage = null;

        public Form1()
        {
            InitializeComponent();
            this.cboECCLevel.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.saveFileDialog1.Filter = "Bitmap Image|*.bmp|PNG Image|*.png|SVG Imagee|*.svg";
            this.saveFileDialog1.Title = "Save QR Code";
            this.saveFileDialog1.ShowDialog();

            if (this.saveFileDialog1.FileName != "")
            {
                if (this.saveFileDialog1.FileName.EndsWith(".svg"))
                {
                    var qrGenerator = new QRCodeGenerator();
                    var codeData = qrGenerator.CreateQrCode(this.txtURL.Text.Trim(), this.eccLevel);
                    var svgImage = new SvgQRCode(codeData);
                    try
                    {
                        string svgString = svgImage.GetGraphic(10);
                        System.IO.FileStream fs = (System.IO.FileStream)this.saveFileDialog1.OpenFile();
                        using (StreamWriter outputFile = new StreamWriter(fs))
                        {
                            outputFile.Write(svgString);
                            outputFile.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(
                            $"Error Saving SVG Image: {ex.Message}",
                            "Error Saving Image",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    var qrGenerator = new QRCodeGenerator();
                    var codeData = qrGenerator.CreateQrCode(this.txtURL.Text.Trim(), this.eccLevel);
                    var qrCodeBitmap = new QRCode(codeData).GetGraphic(
                        pixelsPerModule: 10,
                        darkColor: Color.Black,
                        lightColor: Color.White,
                        icon: this.iconImage,
                        iconSizePercent: Convert.ToInt32(this.numericUpDownIconSize.Value),
                        iconBackgroundColor: Color.White);
                    try
                    {
                        ImageFormat saveFormat = ImageFormat.Bmp;

                        switch (this.saveFileDialog1.FilterIndex)
                        {
                            case 1:
                                saveFormat = ImageFormat.Bmp;
                                break;
                            case 2:
                                saveFormat = ImageFormat.Png;
                                break;
                        }

                        System.IO.FileStream fs = (System.IO.FileStream)this.saveFileDialog1.OpenFile();
                        qrCodeBitmap.Save(fs, saveFormat);
                        fs.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(
                            $"Error Saving BMP Image: {ex.Message}",
                            "Error Saving Image",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
        }

        private void PreviewCode()
        {
            if (txtURL.Text.Trim().Length > 0)
            {
                var qrGenerator = new QRCodeGenerator();
                var codeData = qrGenerator.CreateQrCode(this.txtURL.Text.Trim(), this.eccLevel);
                var qrCodeBitmap = new QRCode(codeData)
                    .GetGraphic(
                        pixelsPerModule: 10,
                        darkColor: Color.Black,
                        lightColor: Color.White,
                        icon: this.iconImage,
                        iconSizePercent: Convert.ToInt32(this.numericUpDownIconSize.Value),
                        iconBackgroundColor: Color.White);
                this.picQRCode.Width = qrCodeBitmap.Width;
                this.picQRCode.Height = qrCodeBitmap.Height;
                this.picQRCode.Image = qrCodeBitmap;
            }
        }

        private void txtURL_TextChanged(object sender, EventArgs e)
        {
            this.PreviewCode();
        }

        private void cboECCLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cboECCLevel.SelectedItem != null)
            {
                switch ((string)this.cboECCLevel.SelectedItem)
                {
                    case "Default":
                        this.eccLevel = QRCodeGenerator.ECCLevel.Default;
                        break;
                    case "L":
                        this.eccLevel = QRCodeGenerator.ECCLevel.L;
                        break;
                    case "M":
                        this.eccLevel = QRCodeGenerator.ECCLevel.M;
                        break;
                    case "Q":
                        this.eccLevel = QRCodeGenerator.ECCLevel.Q;
                        break;
                    case "H":
                        this.eccLevel = QRCodeGenerator.ECCLevel.H;
                        break;
                    default:
                        this.eccLevel = QRCodeGenerator.ECCLevel.Default;
                        break;
                }
            }
            else
            {
                this.eccLevel = QRCodeGenerator.ECCLevel.Default;
            }

            this.PreviewCode();
        }

        private Bitmap? GenerateIconImage()
        {
            if (this.iconImage == null)
                return null;

            int iconSize = Convert.ToInt32(Math.Round(this.numericUpDownIconSize.Value, 0));
            Bitmap result = new Bitmap(iconSize, iconSize);
            Graphics graphics = Graphics.FromImage(result);
            graphics.CompositingMode = CompositingMode.SourceCopy;
            graphics.CompositingQuality = CompositingQuality.HighQuality;
            graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            graphics.SmoothingMode = SmoothingMode.HighQuality;
            graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

            using (ImageAttributes imageAttributes = new ImageAttributes())
            {
                imageAttributes.SetWrapMode((WrapMode.TileFlipXY));
                Rectangle targetSize = new Rectangle(0, 0, iconSize, iconSize);
                graphics.DrawImage(this.iconImage, targetSize, 0, 0, this.iconImage.Width,
                    this.iconImage.Height, GraphicsUnit.Pixel, imageAttributes);
                return result;
            }
        }

        private void btnUploadIcon_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.Filter = "Image Files|*.bmp;*.png|Bitmap Image|*.bmp|PNG Image|*.png";
            DialogResult result = this.openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                try
                {
                    this.iconImage = new Bitmap(this.openFileDialog1.FileName);
                    Bitmap previewImage = new Bitmap(this.picIcon.Width, this.picIcon.Height);
                    Graphics graphics = Graphics.FromImage(previewImage);
                    graphics.CompositingMode = CompositingMode.SourceCopy;
                    graphics.CompositingQuality = CompositingQuality.HighQuality;
                    graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    graphics.SmoothingMode = SmoothingMode.HighQuality;
                    graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                    using (ImageAttributes imageAttributes = new ImageAttributes())
                    {
                        imageAttributes.SetWrapMode((WrapMode.TileFlipXY));
                        Rectangle targetSize = new Rectangle(0, 0, 64, 64);
                        graphics.DrawImage(this.iconImage, targetSize, 0, 0, this.iconImage.Width,
                            this.iconImage.Height, GraphicsUnit.Pixel, imageAttributes);
                        this.picIcon.Image = previewImage;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        $"Error Saving Loading Icon: {ex.Message}",
                        "Error Loading Icon",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                this.PreviewCode();
            }

        }

        private void btnClearIcon_Click(object sender, EventArgs e)
        {
            this.picIcon.Image = null;
            this.iconImage = null;
            this.PreviewCode();
        }

        private void numericUpDownIconSize_ValueChanged(object sender, EventArgs e)
        {
            this.PreviewCode();
        }
    }
}
