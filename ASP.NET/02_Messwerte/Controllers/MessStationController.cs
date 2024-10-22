using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using _02_Messwerte.Data;
using _02_Messwerte.Dto;
using _02_Messwerte.Model;

namespace _02_Messwerte
{
    [Route("api/messtationen")]
    [ApiController]
    public class MessStationController : ControllerBase
    {
        private readonly MessDataContext _context;

        public MessStationController(MessDataContext context)
        {
            _context = context;
        }

        // GET: api/MessStationen
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GetMessStationDto>>> GetMessStationen()
        {
            return _context.MessStationen
                .Include(m => m.MessWerte)
                .ToDtos().ToList();
        }

        // GET: api/MessStationen/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GetMessStationDto>> GetMessStation(int id)
        {
            var messStation = await _context.MessStationen
                .Include(m => m.MessWerte)
                .Where(m => m.Id == id)
                .FirstOrDefaultAsync();

            if (messStation == null)
            {
                return NotFound();
            }

            return messStation.ToDto();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutMessStation(int id, PostMessStationDto messStationDto)
        {
            var messStation = messStationDto.ToDomain();
            messStation.Id = id;
            
            _context.Entry(messStation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MessStationExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<GetMessStationDto>> PostMessStation(PostMessStationDto messStationDto)
        {
            var messStation = messStationDto.ToDomain();
            _context.MessStationen.Add(messStation);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMessStation", new { id = messStation.Id }, messStation);
        }

        [HttpGet("{stationId}/messwerte")]
        public async Task<ActionResult<GetMessStationDto>> GetMessWerte(int stationId)
        {
            if (!MessStationExists(stationId))
            {
                return NotFound();
            }
            
            var messWerte = await _context.MessWert
                .Where(m => m.StationId == stationId)
                .Select(m => m.ToDto())
                .ToListAsync();
            
            return Ok(messWerte);
        }
        
        [HttpGet("{stationId}/messwerte/{messWertId}")]
        public async Task<ActionResult<GetMessStationDto>> GetMessWert(int stationId,int messWertId)
        {

            var messWert =  await _context.MessWert.Where(m => m.Id == messWertId && m.StationId == stationId).FirstOrDefaultAsync();
            if (messWert == null)
            {
                return NotFound();
            }
            
            return Ok(messWert.ToDto());
        }
        
        [HttpPost("{stationId}/messwerte")]
        public async Task<ActionResult<GetMessStationDto>> PostMessWert(int stationId, PostMessWertDto messWertDto)
        {
            var messWert = messWertDto.ToDomain(stationId);
            _context.MessWert.Add(messWert);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMessWert", new { stationId = stationId, messWertId = messWert.Id }, messWert);
        }
        
        [HttpDelete("{stationId}/messwerte/{messWertId}")]
        public async Task<ActionResult<GetMessStationDto>> DeleteMessWert(int stationId, int messWertId)
        {
            var messWert = await _context.MessWert.FindAsync(messWertId);
            if (messWert == null || messWert.StationId != stationId)
            {
                return NotFound();
            } 
            _context.MessWert.Remove(messWert);
            await _context.SaveChangesAsync();

            return NoContent();
        }
        
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMessStation(int id)
        {
            var messStation = await _context.MessStationen.FindAsync(id);
            if (messStation == null)
            {
                return NotFound();
            }

            _context.MessStationen.Remove(messStation);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MessStationExists(int id)
        {
            return _context.MessStationen.Any(e => e.Id == id);
        }
    }
}
