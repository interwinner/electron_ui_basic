namespace ElectronNET.API.Entities
{
    /// <summary>
    /// 
    /// </summary>
    public class AddRepresentationOptions
    {
        /// <summary>
        /// Gets or sets the width
        /// </summary>
        public int? Width { get; set; }

        /// <summary>
        /// Gets or sets the height
        /// </summary>
        public int? Height { get; set; }

        /// <summary>
        /// Gets or sets the scalefactor
        /// </summary>
        public float ScaleFactor { get; set; } = NativeImage.DefaultScaleFactor;

        /// <summary>
        /// Gets or sets the buffer
        /// </summary>
        public byte[] Buffer { get; set; }

        /// <summary>
        /// Gets or sets the dataURL
        /// </summary>
        public string DataUrl { get; set; } 
    }
}