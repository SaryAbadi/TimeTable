﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class AbsencesService
    {
    }
    private bool AbsencesExists(int id)
    {
        return _context.Absences.Any(e => e.Id == id);
    }
}
