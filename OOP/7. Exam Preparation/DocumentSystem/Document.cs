namespace DocumentSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public abstract class Document : IDocument
    {
        public string Name { get; protected set; }

        public string Content { get; protected set; }

        public virtual void LoadProperty(string key, string value)
        {
            if (key == "name")
            {
                this.Name = value;
            }
            else if (key == "content")
            {
                this.Content = value;
            }
        }

        public virtual void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            output.Add(new KeyValuePair<string, object>("name", this.Name));
            output.Add(new KeyValuePair<string, object>("content", this.Content));
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            List<KeyValuePair<string, object>> properties = new List<KeyValuePair<string, object>>();
            this.SaveAllProperties(properties);
            var sortedProperties =
                from item in properties
                orderby item.Key
                select item;

            output.Append(this.GetType().Name);
            output.Append("[");
            foreach (var prop in sortedProperties)
            {
                if (prop.Value!=null)
                {
                    output.Append(String.Format("{0}={1};", prop.Key, prop.Value));
                }
            }

            output.Length--;
            output.Append("]");
            return output.ToString();
        }
    }
}
