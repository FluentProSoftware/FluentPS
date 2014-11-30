using FluentPro.FluentPS.Common.Mapper.Interfaces;
using System.Data;

namespace FluentPro.FluentPS.Common.Mapper.Resolvers.MappingSources
{
    public class DataTableReaderMappingSource : IMappingSource
    {
        private readonly DataTableReader _reader;

        public DataTableReaderMappingSource(DataTableReader reader)
        {
            _reader = reader;
        }

        public object Current
        {
            get { return _reader; }
        }

        public bool Next()
        {
            return _reader.Read();
        }
    }
}
