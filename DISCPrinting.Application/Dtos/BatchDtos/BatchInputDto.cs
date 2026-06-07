using FluentValidation;

namespace DISCPrinting.Application.Dtos.BatchDtos;

public class BatchInputDto
{
    public string Machine { get; set; }
    public string ToolId { get; set; }
    public string CoilCharge { get; set; }
    public string ArticleNumberCoil { get; set; }
    public string ArticleNumberFB { get; set; }
    public string ArticleNumberDB { get; set; }
}
public class BatchInputDtoValidator : AbstractValidator<BatchInputDto>
{
    public BatchInputDtoValidator()
    {
        RuleFor(x => x.Machine)
            .NotNull().NotEmpty().WithMessage("Machine is not empty");
        RuleFor(x => x.ToolId)
            .NotNull().NotEmpty().WithMessage("ToolId is not empty");
        RuleFor(x => x.CoilCharge)
            .NotNull().NotEmpty().WithMessage("CoilCharge is not empty");
        RuleFor(x => x.ArticleNumberCoil)
            .NotNull().NotEmpty().WithMessage("ArticleNumberCoil is not empty");
        RuleFor(x => x.ArticleNumberFB)
            .NotNull().NotEmpty().WithMessage("ArticleNumberFB is not empty");
        RuleFor(x => x.ArticleNumberDB)
            .NotNull().NotEmpty().WithMessage("ArticleNumberDB is not empty");
    }
}