﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace RECSClimate
{
    public interface IFileService
    {
        /// <summary>
        /// Use to save file in device specific folders
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="fileStream"></param>
        /// <returns></returns>
        string SaveFile(string fileName, byte[] fileStream);

        /// <summary>
        /// Used to delete the existing file directory, before syncing the file again.
        /// </summary>
        void DeleteDirectory();

    }
}
