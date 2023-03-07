namespace Common.Utils
{
    public static class Utils
    {
        public static T Parse<T>(string value) where T : struct, Enum
        {
            return Enum.TryParse<T>(value, out var result) ? result : throw new ArgumentException($"Invalid value '{value}' for enum type {typeof(T)}");
        }

        public static byte[] GetFileBytes(string filePath)
        {
            byte[] fileBytes;

            using (var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            using (var binaryReader = new BinaryReader(fileStream))
            {
                fileBytes = binaryReader.ReadBytes((int)fileStream.Length);
            }

            return fileBytes;
        }
    }
}