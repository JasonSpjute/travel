using System;
using System.Collections.Generic;
using travel.Models;
using travel.Repositories;

namespace travel.Services
{
    public class VacationsService
    {
        private readonly VacationsRepository _repo;
        public VacationsService(VacationsRepository repo)
        {
            _repo = repo;
        }
        internal IEnumerable<Vacation> GetAll()
        {
            return _repo.GetAll();
        }
    }
}