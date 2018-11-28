using ClusterServer.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ClusterServer.Controllers
{
    [Route("api/cluster")]
    public class ClusterController : Controller
    {
        IClusterService clusterService;

        public ClusterController(IClusterService cs)
        {
            this.clusterService = cs;
        }


        // GET api/values
        [HttpGet]
        public ActionResult Get()
        {
            return Json(clusterService.GetBlogs());
        }

        [HttpGet("blogs")]
        public ActionResult GetBlogs()
        {
            return Json(clusterService.GetBlogs());
        }

        [HttpGet("hierarchical")]
        public ActionResult GetHierarchical()
        {
            return Json(clusterService.GetHierarchicalCluster(), new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            });
        }

        [HttpGet("kmeans")]
        public ActionResult GetKMeans()
        {
            return Json(clusterService.GetKMeansCluster());
        }

        [HttpGet("kmeanshalt")]
        public ActionResult GetKMeansSelfHalting()
        {
            return Json(clusterService.GetKMeansClusterSelfHalt());
        }


    }
}
