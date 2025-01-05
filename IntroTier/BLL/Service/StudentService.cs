using AutoMapper;
using BLL.DTOs;
using DAL.EF.Tables;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service
{
    public class StudentService 
    {
        public static List<StudentDTO> GetAll()
        {
            var srepo = new StudentRepo();
            var data = srepo.Get();
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Student, StudentDTO>();
            });
            var mapper = new Mapper(config); ;
            var ret = mapper.Map<List<StudentDTO>>(data);

            return ret;

        }
        public static StudentDTO Get(int id)
        {
            var srepo = new StudentRepo();
            var data = srepo.Get(id);
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Student, StudentDTO>();
            });
            var mapper = new Mapper(config); ;
            var ret = mapper.Map<StudentDTO>(data);
            return ret;
        }
        public static void Create(StudentDTO s)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<StudentDTO, Student>();
            });
            var mapper = new Mapper(config); ;
            var st = mapper.Map<Student>(s);
            var repo = new StudentRepo();
            repo.Create(st);
        }
        public static void Update(int id, StudentDTO s)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<StudentDTO, Student>();
            });
            var mapper = new Mapper(config);
            var student = mapper.Map<Student>(s); 
            student.Id = id; 
            var repo = new StudentRepo();
            repo.Update(student); 
        }
        public static void Delete(int id)
        {
            var repo = new StudentRepo();
            repo.Delete(id); 
        }


    }
}
