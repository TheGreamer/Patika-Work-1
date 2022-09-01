namespace PatikaClassWork1.Utilities
{
    public class Message
    {
        public static readonly string ID_NULL = "Id can't be empty.";
        public static readonly string NOT_EMPTY = "Must not be empty.";
        public static readonly string NOT_FOUND = "No item found.";
        public static readonly string ADDED = "Added successfully.";
        public static readonly string UPDATED = "Updated successfully.";
        public static readonly string DELETED = "Deleted successfully.";
        public static readonly string AUTHOR_DELETE_ERROR = "There are books registered for this author in the system. In order to delete this author, registered books must be deleted first.";
        public static readonly string NAME_LENGTH_ERROR = "Length must be between 3 and 30.";
        public static readonly string DESCRIPTION_LENGTH_ERROR = "Length must be between 5 and 500.";
        public static readonly string DATE_ERROR = $"Date must be between 01.01.1800 and {DateTime.Now:d}";
    }
}