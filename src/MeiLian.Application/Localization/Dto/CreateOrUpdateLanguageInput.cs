using System.ComponentModel.DataAnnotations;

namespace MeiLian.Localization.Dto
{
    public class CreateOrUpdateLanguageInput
    {
        [Required]
        public ApplicationLanguageEditDto Language { get; set; }
    }
}
