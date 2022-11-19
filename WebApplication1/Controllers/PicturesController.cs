using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WebApplication1.Entites;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class PicturesController : ApiController
    {
        private RegistrEntities db = new RegistrEntities();

        // GET: api/Pictures
        [ResponseType(typeof(List<PicturesModels>))]
        public IHttpActionResult GetPictures()
        {
            return Ok(db.Pictures.ToList().ConvertAll(x=> new PicturesModels(x)));
        }

        // GET: api/Pictures/5
        [ResponseType(typeof(Pictures))]
        public IHttpActionResult GetPictures(int id)
        {
            Pictures pictures = db.Pictures.Find(id);
            if (pictures == null)
            {
                return NotFound();
            }

            return Ok(pictures);
        }

        // PUT: api/Pictures/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutPictures(int id, Pictures pictures)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != pictures.Id)
            {
                return BadRequest();
            }

            db.Entry(pictures).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PicturesExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Pictures
        [ResponseType(typeof(Pictures))]
        public IHttpActionResult PostPictures(Pictures pictures)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Pictures.Add(pictures);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = pictures.Id }, pictures);
        }

        // DELETE: api/Pictures/5
        [ResponseType(typeof(Pictures))]
        public IHttpActionResult DeletePictures(int id)
        {
            Pictures pictures = db.Pictures.Find(id);
            if (pictures == null)
            {
                return NotFound();
            }

            db.Pictures.Remove(pictures);
            db.SaveChanges();

            return Ok(pictures);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PicturesExists(int id)
        {
            return db.Pictures.Count(e => e.Id == id) > 0;
        }
    }
}