﻿using Grand.Infrastructure;
using Grand.Web.Common.Components;
using Grand.Web.Features.Models.Catalog;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Grand.Web.Components;

public class HomePageBrandsViewComponent : BaseViewComponent
{
    private readonly IMediator _mediator;
    private readonly IWorkContext _workContext;

    public HomePageBrandsViewComponent(
        IMediator mediator,
        IWorkContext workContext)
    {
        _mediator = mediator;
        _workContext = workContext;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var model = await _mediator.Send(new GetHomepageBrands {
            Customer = _workContext.CurrentCustomer,
            Language = _workContext.WorkingLanguage,
            Store = _workContext.CurrentStore
        });

        return !model.Any() ? Content("") : View(model);
    }
}