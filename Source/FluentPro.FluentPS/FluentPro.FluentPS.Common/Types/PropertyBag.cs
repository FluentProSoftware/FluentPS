using FluentPro.FluentPS.Common.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FluentPro.FluentPS.Common.Types
{
    public class PropertyBag : IEnumerable<KeyValuePair<string, object>>
    {
        private readonly Dictionary<string, object> _properties;

        public PropertyBag()
        {
            _properties = new Dictionary<string, object>();
        }

        public PropertyBag(Dictionary<string, object> properties)
        {
            foreach (var prop in properties)
            {
                if (_properties.ContainsKey(prop.Key))
                {
                    continue;
                }

                _properties.Add(prop.Key, prop.Value);
            }
        }

        #region Methods

        public void Update(PropertyBag newBag)
        {
            for (var i = 0; i < newBag._properties.Count; i++)
            {
                var prop = newBag._properties.ElementAt(i);
                if (_properties.ContainsKey(prop.Key))
                {
                    _properties[prop.Key] = prop.Value;
                    continue;
                }

                _properties.Add(prop.Key, prop.Value);
            }
        }

        public bool ContainsProperty(string propertyName)
        {
            return _properties.ContainsKey(propertyName);
        }

        public PropertyBag CloneWithProperties(HashSet<string> propertyNames)
        {
            var newBag = new PropertyBag();
            foreach (var propertyName in propertyNames)
            {
                if (_properties.ContainsKey(propertyName))
                {
                    newBag[propertyName] = _properties[propertyName];
                }
            }

            return newBag;
        }

        #endregion // Methods

        #region Indexer

        public object this[string propertyName]
        {
            get { return GetValue(propertyName); }
            set { SetValue(propertyName, value); }
        }

        private void SetValue(string propertyName, object value)
        {
            if (!_properties.ContainsKey(propertyName))
            {
                _properties.Add(propertyName, value);
                return;
            }

            _properties[propertyName] = value;
        }

        private object GetValue(string propertyName)
        {
            if (_properties.ContainsKey(propertyName))
            {
                return _properties[propertyName];
            }

            throw new PropertyBagPropertyMissingException(string.Format("No property '{0}' in property bag", propertyName), propertyName);
        }

        public object this[int idx]
        {
            get { return GetValue(idx); }
        }

        private object GetValue(int idx)
        {
            var list = _properties.ToList();
            return list[idx].Value;
        }

        #endregion // Indexer

        #region IEnumerator wrapper

        public IEnumerator<KeyValuePair<string, object>> GetEnumerator()
        {
            return _properties.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _properties.GetEnumerator();
        }

        #endregion // IEnumerator wrapper

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendFormat("[");
            foreach (var property in _properties)
            {
                sb.AppendFormat("'{0}' : '{1}', ", property.Key, property.Value);
            }

            sb.AppendFormat("]");
            return sb.ToString();
        }
    }
}
