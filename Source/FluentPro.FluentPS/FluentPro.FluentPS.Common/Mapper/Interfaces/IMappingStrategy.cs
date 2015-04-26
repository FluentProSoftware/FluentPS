﻿using FluentPro.FluentPS.Common.Types;

namespace FluentPro.FluentPS.Common.Mapper.Interfaces
{
    public interface IMappingStrategy
    {
        void Map(MappingPair mappingPair, IMappingConfiguration config);
        
        // It is suggested to implement following method as part of a strategy
        // public static bool CanMap(MappingPair mappingObjects);
    }
}
