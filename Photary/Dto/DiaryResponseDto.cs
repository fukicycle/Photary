using System;
namespace Photary.Dto
{
	public class DiaryResponseDto
	{
        public string Content { get; set; } = null!;
        public DateTime Date { get; set; }
        public string? ImagePath { get; set; }
    }
}

