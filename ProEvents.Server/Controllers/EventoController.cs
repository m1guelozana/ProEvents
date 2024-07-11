using System;
using Microsoft.AspNetCore.Mvc;
using ProEvents.Server.API.Models;

namespace ProEvents.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _evento = new Evento[]
        {
            new Evento()
            {
                EventoId = 1,
                Tema = "Angular e .net",
                Local = "Rio de Janeiro",
                Lote = "Lote 1",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
            },
            new Evento()
            {
                EventoId = 2,
                Tema = "Balada na praia",
                Local = "Rio de Janeiro",
                Lote = "Lote 1",
                QtdPessoas = 500,
                DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
            },
        };

        public EventoController()
        {
             
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where(evento => evento.EventoId == id);
        }
    }
}
            