namespace CSDeskBand
{
    using System;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    /// <summary>
    /// Size class that is independent of winforms or wpf.
    /// </summary>
    public sealed class DeskBandSize : INotifyPropertyChanged
    {
        private int _width;
        private int _height;

        /// <summary>
        /// Initializes a new instance of the <see cref="DeskBandSize"/> class.
        /// </summary>
        /// <param name="width">The <see cref="Width"/> component.</param>
        /// <param name="height">The <see cref="Height"/> component.</param>
        public DeskBandSize(int width, int height)
        {
            Width = width;
            Height = height;
        }

        /// <inheritdoc/>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets or sets the width component of the size.
        /// </summary>
        public int Width
        {
            get => _width;
            set
            {
                if (value == _width)
                {
                    return;
                }

                _width = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the height component of the size.
        /// </summary>
        public int Height
        {
            get => _height;
            set
            {
                if (value == _height)
                {
                    return;
                }

                _height = value;
                OnPropertyChanged();
            }
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}