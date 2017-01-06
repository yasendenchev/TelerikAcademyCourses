using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security;

namespace Point3D
{
    class PathStorage
    {
        public static void Save(Path current)
        {
            try
            {
                StreamWriter writer = new StreamWriter("path.txt");

                using (writer)
                {
                    foreach (var item in current.Sequence)
                    {
                        writer.WriteLine("{0}, {1}, {2}", item.X, item.Y, item.Z);
                        writer.Flush();
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The file is not found.");
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("The specified path, file name, or both exceed the system-defined maximum length.");
                Console.WriteLine("Paths must be less than 248 characters, and file names must be less than 260 characters.");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("The specified path is invalid.");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("The file path is INCORRECT.");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Path specified a file that is read-only. \n -or- This operation is not supported on the current platform.\n -or- Path specified a directory.\n -or- The caller does not have the required permission.");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("Path is in an invalid format.");
            }
            catch (IOException)
            {
                Console.WriteLine("An I/O error occurred while opening the file.");
            }
            catch (SecurityException)
            {
                Console.WriteLine("You don't have permission to access this file.");
            }

        }

        public static Path LoadPath(string filePath)
        {
            Path loadPath = new Path();

            try
            {

                StreamReader reader = new StreamReader(filePath);
                using (reader)
                {
                    int lineNumber = 0;
                    string line = reader.ReadLine();

                    while (line != null)
                    {
                        lineNumber++;
                        string[] coordinates = line.Split(new char[] { '(', ',', ')' }, StringSplitOptions.RemoveEmptyEntries); loadPath.AddPoint(new Point3D(int.Parse(coordinates[0]), int.Parse(coordinates[1]), int.Parse(coordinates[2])));
                        line = reader.ReadLine();
                    }

                }
            }

            catch (FileNotFoundException)
            {
                Console.WriteLine("The file is not found.");
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("The specified path, file name, or both exceed the system-defined maximum length.");
                Console.WriteLine("Paths must be less than 248 characters, and file names must be less than 260 characters.");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("The specified path is invalid.");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("The file path is INCORRECT.");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Path specified a file that is read-only. \n -or- This operation is not supported on the current platform.\n -or- Path specified a directory.\n -or- The caller does not have the required permission.");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("Path is in an invalid format.");
            }
            catch (IOException)
            {
                Console.WriteLine("An I/O error occurred while opening the file.");
            }
            catch (SecurityException)
            {
                Console.WriteLine("You don't have permission to access this file.");
            }

            return loadPath;
        }
    }
}
