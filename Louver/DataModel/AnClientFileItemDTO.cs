using Louver.Models;

namespace Louver.DataModel
{
    public class AnClientFileItemDTO
    {
        public int ClientFileitemId { get; set; }

        public int? ClientFileiD { get; set; }

        public int? UnitId { get; set; }

        public int? MaterialId { get; set; }

        public string? Color { get; set; }

        public int? FinalStatusId { get; set; }

        public int? Grain { get; set; }

        public string? Notes { get; set; }

        public int? CuttingListCategoryId { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? CreationDate { get; set; }

        public int? ModifiedBy { get; set; }

        public DateTime? ModificationDate { get; set; }
        public virtual ICollection<AnClientFileDetailDTO> AnClientFileDetailsDTO { get; set; } = new List<AnClientFileDetailDTO>();

    }
}
