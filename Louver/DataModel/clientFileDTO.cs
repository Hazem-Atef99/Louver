﻿namespace Louver.DataModel
{
    public class clientFileDTO
    {
        public int ClientFileId { get; set; }

        public int? FileNo { get; set; }
        public string? ClientClientName { get; set; }
        public string? KitchenTypeDes { get; set; }
        public DateTime? FileDate { get; set; }
        public DateTime? TarkeebDate { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? ModificationDate { get; set; }
        public int? FinalStatusId { get; set; }

        public string? ClientFileStatus { get; set; }

    }
}
