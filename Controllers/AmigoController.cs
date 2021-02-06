using System;
using System.Collections.Generic;
using Instadev_06.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Instadev_06.Controllers
{
    [Route("Amigo")]
    public class AmigoController : Controller
    {
        Usuario usuarioModel = new Usuario();
        Publicacao publicacaoModel = new Publicacao();
        Comentario comentarioModel = new Comentario();

        public IActionResult Index(IFormCollection form, string mine)
        {
            var userId = HttpContext.Session.GetString("_UserId");
            ViewBag.UserLogado = usuarioModel.ObterUsuarioDaSessao(int.Parse(userId));

            ViewBag.Comentarios = comentarioModel.ReadAll();
            
            ViewBag.UsuarioClicado = ObterUsuarioClicado(int.Parse(form["IdAmigo"]));

            ViewBag.PostAmigo = ExibirPublicacoes(int.Parse(form["IdAmigo"]));

            return View();
        }

        [Route("Exibir")]
        public List<Publicacao> ExibirPublicacoes(int id)
        {
            List<Publicacao> posts = new List<Publicacao>();
            List<string> publicacoes = publicacaoModel.ReadAllLinesCSV(publicacaoModel._PATH);
            
            var pub = publicacoes.FindAll(x => x.Split(";")[3] == id.ToString());

            foreach (var item in pub)
            {
                string[] linha = item.Split(";");

                Publicacao publicacao = new Publicacao();
                publicacao.IdPublicacao = int.Parse(linha[0]);
                publicacao.Imagem = linha[1];
                publicacao.Legenda = linha[2];
                publicacao.IdUsuario = int.Parse(linha[3]);
                publicacao.Likes = int.Parse(linha[4]);
                publicacao.Username = linha[6];

                posts.Add(publicacao);
            }

            return posts;
        }

        [Route("ObterUsuarioClicado")]
        public Usuario ObterUsuarioClicado(int id)
        {
            List<string> usuarios = usuarioModel.ReadAllLinesCSV(usuarioModel._PATH);

            var userLogado = usuarios.Find(x => x.Split(";")[0] == id.ToString());

            string[] atributo = userLogado.Split(";");

            Usuario usuario = new Usuario();
            usuario.IdUsuario = int.Parse(atributo[0]);
            usuario.Nome = atributo[1];
            usuario.Foto = atributo[2];
            usuario.DataNascimento = DateTime.Parse(atributo[3]);
            usuario.Username = atributo[4];

            return usuario;
        }

        // [Route("bla")]
        // public IActionResult HandleButtonClick(string mine)
        // {
        //     int num = int.Parse(mine);
        //     if(num == 0)
        //     {
        //         numero = 1;
        //     } else {
        //         numero = 0;
        //     }

        //     return View("Index", numero);
        // }
    }
}