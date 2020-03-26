using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BattleshipWebApp.Models
{
    public class Board
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Game")]
        public int GameId { get; set; }
        public Game Game { get; set; }
        [ForeignKey("Player")]
        public int PlayerId { get; set; }
        public Player Player { get; set; }
        public int[][] BoardGrid { get; set; }
    }
}
