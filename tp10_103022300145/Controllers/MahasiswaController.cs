
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using tp10_103022300145;

namespace tp10_103022300145.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaController : ControllerBase
    {
        public static readonly List<Mahasiswa> mahasiswaL = new List<Mahasiswa>
        {
            new Mahasiswa("Elvina Nilysti Huang", "103022300145"),
            new Mahasiswa("Ahmad Naufal Alghifari", "103022300006"),
            new Mahasiswa("Maulana Jidan Azizi", "103022300083"),
            new Mahasiswa("Wildan Nabil Ramdhany", "103022300095"),
            new Mahasiswa("Abizar Tsaqif Abrar", "103022330128"),
            new Mahasiswa("Mikdam Huda", "1302223034"),
            new Mahasiswa("Hafidz Zuhayr Shidiq", "103022300019")
        };

        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return mahasiswaL;
        }

        [HttpGet("{index}")]

        public Mahasiswa Get(int index)
        {
            return mahasiswaL[index];
        }

        [HttpPost]

        public void Post([FromBody] Mahasiswa value)
        {
            mahasiswaL.Add(value);
        }

        [HttpDelete("{index}")]

        public void Delete(int index)
        {
            mahasiswaL.RemoveAt(index);
        }
    }
}