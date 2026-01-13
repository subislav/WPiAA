using System;
using System.Collections.Generic;

namespace Flyweight
{
    public class TextureFactory
    {
        private Dictionary<string, SharedTexture> _textures = new Dictionary<string, SharedTexture>();
        public SharedTexture GetTexture(string filename)
        {
            if (!_textures.ContainsKey(filename))
            {
                _textures[filename] = new SharedTexture(filename);
            }
            return _textures[filename];
        }
    }
}