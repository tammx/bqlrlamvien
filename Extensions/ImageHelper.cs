using ImageMagick;
using System.IO;

namespace minhlamcons.Extensions
{
    public static class ImageHelper
    {
        /// <summary>
        /// Resize + Compress ảnh bằng Magick.NET (hỗ trợ cả RAW/DNG).
        /// </summary>
        /// <param name="input">Stream ảnh gốc</param>
        /// <param name="savePath">Đường dẫn lưu file đã xử lý</param>
        /// <param name="maxWidth">Chiều rộng tối đa</param>
        /// <param name="maxHeight">Chiều cao tối đa</param>
        /// <param name="quality">Độ nén (0–100)</param>
        public static void ResizeImageMagick(Stream input, string savePath,
                                             int maxWidth = 1280, int maxHeight = 1280,
                                             int quality = 75)
        {
            // Đọc ảnh (Magick.NET hỗ trợ rất nhiều định dạng)
            using (var image = new MagickImage(input))
            {
                // Resize nếu ảnh lớn hơn giới hạn
                if (image.Width > maxWidth || image.Height > maxHeight)
                {
                    var size = new MagickGeometry((uint)maxWidth, (uint)maxHeight)
                    {
                        IgnoreAspectRatio = false  // Giữ tỷ lệ ảnh
                    };
                    image.Resize(size);
                }

                // Thiết lập chất lượng nén (JPG/WebP)
                image.Quality = (uint)quality;

                // Nếu là PNG → convert sang JPG để giảm dung lượng (tùy bạn)
                if (image.Format == MagickFormat.Png)
                    image.Format = MagickFormat.Jpeg;

                // Nếu ảnh là RAW/DNG → convert sang JPEG
                if (image.Format.ToString().ToLower().Contains("dng") ||
                    image.Format.ToString().ToLower().Contains("raw"))
                {
                    image.Format = MagickFormat.Jpeg;
                }

                // Lưu file
                image.Write(savePath);
            }
        }
    }
}
