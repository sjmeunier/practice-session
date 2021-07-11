using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace PracticeSession.Core
{
    public class MostRecentlyUsedList
    {
        private int _limit;
        private string _mruFilename;
        private List<string> _items;

        public MostRecentlyUsedList(int limit, string mruFilename)
        {
            if (limit <= 0)
            {
                throw new ArgumentOutOfRangeException("limit", "limit must be greater than zero.");
            }

            _limit = limit;
            _mruFilename = mruFilename;

            _items = new List<string>();

            LoadFromFile();
        }

        public int Limit
        {
            get { return _limit; }
        }

        public List<string> Items
        {
            get { return new List<string>(_items); }
        }

        public void Add(string item)
        {
            if (_items.Contains(item))
            {
                _items.Remove(item);
            }

            _items.Insert(0, item);

            RemoveExtraItems();

            SaveToFile();
        }

        /// <summary>
        /// Remove a single item
        /// </summary>
        /// <param name="item"></param>
        public void Remove(string item)
        {
            if (_items.Contains(item))
            {
                _items.Remove(item);
                SaveToFile();
            }
        }

        public void Clear()
        {
            ClearItems();

            SaveToFile();
        }

        /// <summary>
        /// Clears MRU items
        /// </summary>
        private void ClearItems()
        {
            _items.Clear();
        }

        /// <summary>
        /// Saves MRU Items to file
        /// </summary>
        private void SaveToFile()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(_mruFilename, false, Encoding.UTF8))
                {
                    foreach (string item in _items)
                    {
                        writer.WriteLine(item);
                    }

                    writer.Flush();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Unable to save MRU list to disk." + e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Loads MRU items from file
        /// </summary>
        private void LoadFromFile()
        {
            if (!File.Exists(_mruFilename))
                return;

            ClearItems();

            // Open MRU file with read access
            FileStream fileStream = File.OpenRead(_mruFilename);

            using (StreamReader reader = new StreamReader(fileStream))
            {
                while (!reader.EndOfStream && _items.Count < _limit)
                {
                    string mruItem = reader.ReadLine();
                    _items.Add(mruItem);
                }
            }
        }

        /// <summary>
        /// Removes the extra items
        /// </summary>
        private void RemoveExtraItems()
        {
            if (_items.Count > Limit)
            {
                for (int x = Limit; x < _items.Count; x++)
                {
                    _items.RemoveAt(x);
                }
            }
        }

    }
}
