﻿// ===========================================================================================================
//      _                                 _              _       _                 
//     | |                               | |            | |     | |                
//   __| |   __ _  __  __  _ __     ___  | |_   ______  | |__   | |   ___     __ _ 
//  / _` |  / _` | \ \/ / | '_ \   / _ \ | __| |______| | '_ \  | |  / _ \   / _` |
// | (_| | | (_| |  >  <  | | | | |  __/ | |_           | |_) | | | | (_) | | (_| |
//  \__,_|  \__,_| /_/\_\ |_| |_|  \___|  \__|          |_.__/  |_|  \___/   \__, |
//                                                                            __/ |
//                                                                           |___/ 
//
// 
// Daxnet Personal Blog
// Copyright © 2016 by daxnet (Sunny Chen)
//
// https://github.com/daxnet/daxnet-blog
//
// MIT License
// 
// Copyright(c) 2016 Sunny Chen
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
// ===========================================================================================================

namespace DaxnetBlog.Common.IntegrationServices
{
    /// <summary>
    /// Represents that the implemented classes are caching services. 
    /// </summary>
    public interface ICachingService
    {
        /// <summary>
        /// Puts the object into the cache by using specified key.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="value">The value.</param>
        void Put(CachingKey key, object value);

        /// <summary>
        /// Gets the cached object by using specified key.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns></returns>
        object Get(CachingKey key);

        /// <summary>
        /// Deletes the specified key.
        /// </summary>
        /// <param name="key">The key.</param>
        void Delete(CachingKey key);

        void DeleteByPrefix(string prefix);

    }
}
