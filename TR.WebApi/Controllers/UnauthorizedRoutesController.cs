// using System.Diagnostics;
// using System.Collections.Generic;
// using Microsoft.AspNetCore.Mvc;
// // using technicalRadiation.Models.Dtos;
// // using technicalRadiation.Models.InputModels;
// // using technicalRadiation.Services;
// using System;
// // using technicalRadiation.Models.Exceptions;
// // using technicalRadiation.WebApi.Extensions;


// namespace technicalRadiation.webApi
// {
//   // Starting Route 
//   [Route("api")]
//   public class NewsController : Controller
//   {
//     /* 
//     fetch all news
//     */
//     // private NewsService _newsService = new NewsService();

//     private AuthorizationService _authorizationService = new AuthorizationService();

//     // get by id localhost:5000/api/v1
//     [HttpGet]
//     [Route("")]
//     /*
//     s. The limit can be changed via a query parameter called pageSize.
//     The pages can be indexed by a query parameter called pageNumber
//     */
//     public IActionResult GetAllNewsItems([FromQuery] int pageSize, [FromQuery] int pageNumber)
//     {
//       return Ok(_newsService.GetAllNewsItems(pageSize, pageNumber));
//     }

//     /*
//     Create an endpoint (/api/{newsItemId}) which accepts an URL parameter for the
//     news item id. This endpoint should retrieve a news item by id.
//     */


//   }

// }