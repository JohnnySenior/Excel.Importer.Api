﻿//===========================
// Copyright (c) Tarteeb LLC
// Powering True Leadership
//===========================

using Excel.Importer.Models.Applicants;
using System;
using System.Threading.Tasks;

namespace Excel.Importer.Services.Foundations.Applicants
{
    public interface IApplicantService
    {
        ValueTask<Applicant> AddApplicantAsync(Applicant applicant);
        ValueTask<Applicant> RemoveApplicantAsync(Guid guid);
    }
}
