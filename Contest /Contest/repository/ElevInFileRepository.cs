﻿using System;
using System.Collections.Generic;
using System.Text;
using Lab9_MAP.model;
using Lab9_MAP.validator;

namespace Lab9_MAP.repository
{
    class ElevInFileRepository:InFileRepository<string,Elev>
    {
        public ElevInFileRepository(IValidator<Elev> validator, string filename) : base(validator, filename, EntityToFileMapping.CreateElev) { }
    }
}
