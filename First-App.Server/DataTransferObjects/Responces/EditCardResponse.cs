﻿namespace First_App.Server.DataTransferObjects.Responces
{
    public class EditCardResponse
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTime? DueDate { get; set; }
        public int? CardColumnId { get; set; }
    }
}