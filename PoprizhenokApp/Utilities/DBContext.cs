using PoprizhenokApp.Models;

namespace PoprizhenokApp.Utilities
{
    internal class DBContext
    {
        private static ModelDB _context { get; set; }
        public static ModelDB Context { get => _context ?? (_context = new ModelDB()); }
    }
}
