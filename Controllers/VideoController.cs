﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.Data.SqlClient;
using System.Data;
using MVCLaboratorio.Utilerias;

namespace MVCLaboratorio.Controllers
{
    public class VideoController : Controller
    {
        //
        // GET: /Video/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(int idVideo, string titulo, int repro, string url)
        {
            //Guardar datos
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@idVideo", idVideo));
            parametros.Add(new SqlParameter("@titulo", titulo));
            parametros.Add(new SqlParameter("@repro", repro));
            parametros.Add(new SqlParameter("@url", url));
            
            BaseHelper.ejecutarSentencia("sp_video_insertar", CommandType.StoredProcedure, parametros);

            return RedirectToAction("Index","Videos");
        }
        public ActionResult Edit()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Edit(int idVideo)
        {
            return View();
        }
        public ActionResult Delete()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Delete(int idVideo)
        {
            return View();
        }
    }
}
