﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PDMAula05.Model {
    public class Aluno {
        public Guid Id { get; set; }
        public string RM { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
    }
}