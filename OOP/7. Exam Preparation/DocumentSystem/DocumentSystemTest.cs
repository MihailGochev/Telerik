namespace DocumentSystem
{
    using System;
    using System.Collections.Generic;

    public class DocumentSystemTest
    {
        public static List<IDocument> AllDocuments = new List<IDocument>();

        static void Main()
        {
            IList<string> allCommands = ReadAllCommands();
            ExecuteCommands(allCommands);
        }

        private static IList<string> ReadAllCommands()
        {
            List<string> commands = new List<string>();
            while (true)
            {
                string commandLine = Console.ReadLine();
                if (commandLine == "")
                {
                    // End of commands
                    break;
                }
                commands.Add(commandLine);
            }
            return commands;
        }

        private static void ExecuteCommands(IList<string> commands)
        {
            foreach (var commandLine in commands)
            {
                int paramsStartIndex = commandLine.IndexOf("[");
                string cmd = commandLine.Substring(0, paramsStartIndex);
                int paramsEndIndex = commandLine.IndexOf("]");
                string parameters = commandLine.Substring(
                    paramsStartIndex + 1, paramsEndIndex - paramsStartIndex - 1);
                ExecuteCommand(cmd, parameters);
            }
        }

        private static void ExecuteCommand(string cmd, string parameters)
        {
            string[] cmdAttributes = parameters.Split(
                new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            if (cmd == "AddTextDocument")
            {
                AddTextDocument(cmdAttributes);
            }
            else if (cmd == "AddPDFDocument")
            {
                AddPdfDocument(cmdAttributes);
            }
            else if (cmd == "AddWordDocument")
            {
                AddWordDocument(cmdAttributes);
            }
            else if (cmd == "AddExcelDocument")
            {
                AddExcelDocument(cmdAttributes);
            }
            else if (cmd == "AddAudioDocument")
            {
                AddAudioDocument(cmdAttributes);
            }
            else if (cmd == "AddVideoDocument")
            {
                AddVideoDocument(cmdAttributes);
            }
            else if (cmd == "ListDocuments")
            {
                ListDocuments();
            }
            else if (cmd == "EncryptDocument")
            {
                EncryptDocument(parameters);
            }
            else if (cmd == "DecryptDocument")
            {
                DecryptDocument(parameters);
            }
            else if (cmd == "EncryptAllDocuments")
            {
                EncryptAllDocuments();
            }
            else if (cmd == "ChangeContent")
            {
                ChangeContent(cmdAttributes[0], cmdAttributes[1]);
            }
            else
            {
                throw new InvalidOperationException("Invalid command: " + cmd);
            }
        }

        private static void AddDocument(IDocument document, string[] attributes)
        {
            foreach (var prop in attributes)
            {
                var properties = prop.Split('=');
                document.LoadProperty(properties[0], properties[1]);
            }

            if (document.Name == null)
            {
                Console.WriteLine("Document has no name");
            }
            else
            {
                Console.WriteLine("Document added: " + document.Name);
                AllDocuments.Add(document);
            }
        }

        private static void AddTextDocument(string[] attributes)
        {
            AddDocument(new TextDocument(), attributes);
        }

        private static void AddPdfDocument(string[] attributes)
        {
            AddDocument(new PDFDocument(), attributes);
        }

        private static void AddWordDocument(string[] attributes)
        {
            AddDocument(new WordDocument(), attributes);
        }

        private static void AddExcelDocument(string[] attributes)
        {
            AddDocument(new ExcelDocument(), attributes);
        }

        private static void AddAudioDocument(string[] attributes)
        {
            AddDocument(new AudioDocument(), attributes);
        }

        private static void AddVideoDocument(string[] attributes)
        {
            AddDocument(new VideoDocument(), attributes);
        }

        private static void ListDocuments()
        {
            bool documentFound = false;

            foreach (var document in AllDocuments)
            {
                documentFound = true;
                Console.WriteLine(document);
            }

            if (!documentFound)
            {
                Console.WriteLine("No documents found");
            }
        }

        private static void EncryptDocument(string name)
        {
            bool documentFound = false;

            foreach (var document in AllDocuments)
            {
                if (document.Name == name)
                {
                    documentFound = true;
                    if (document is IEncryptable)
                    {
                        ((IEncryptable)document).Encrypt();
                        Console.WriteLine("Document encrypted: " + name);
                    }
                    else
                    {
                        Console.WriteLine("Document does not support encryption: " + name);
                    }
                }
            }

            if (!documentFound)
            {
                Console.WriteLine("Document not found: " + name);
            }
        }

        private static void DecryptDocument(string name)
        {
            bool documentFound = false;

            foreach (var document in AllDocuments)
            {
                if (document.Name == name)
                {
                    documentFound = true;
                    if (document is IEncryptable)
                    {
                        ((IEncryptable)document).Decrypt();
                        Console.WriteLine("Document decrypted: " + name);
                    }
                    else
                    {
                        Console.WriteLine("Document does not support decryption: " + name);
                    }
                }
            }

            if (!documentFound)
            {
                Console.WriteLine("Document not found: " + name);
            }
        }

        private static void EncryptAllDocuments()
        {
            bool documentFound = false;

            foreach (var document in AllDocuments)
            {
                if (document is IEncryptable)
                {
                    documentFound = true;
                    ((IEncryptable)document).Encrypt();
                }
            }

            if (documentFound)
            {
                Console.WriteLine("All documents encrypted");
            }
            else
            {
                Console.WriteLine("No encryptable documents found");
            }
        }

        private static void ChangeContent(string name, string content)
        {
            bool documentFound = false;

            foreach (var document in AllDocuments)
            {
                if (document.Name == name)
                {
                    documentFound = true;
                    if (document is IEditable)
                    {
                        ((IEditable)document).ChangeContent(content);
                        Console.WriteLine("Document content changed: " + name);
                    }
                    else
                    {
                        Console.WriteLine("Document is not editable: " + name);
                    }
                }
            }

            if (!documentFound)
            {
                Console.WriteLine("Document not found: " + name);
            }
        }
    }
}
