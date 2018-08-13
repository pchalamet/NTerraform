using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_budgets_budget")]
    public sealed class aws_budgets_budget : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "cost_types")]
        public sealed class cost_types : nterraform.Core.structure
        {
            public cost_types(bool? @includeCredit = null,
                              bool? @includeDiscount = null,
                              bool? @includeOtherSubscription = null,
                              bool? @includeRecurring = null,
                              bool? @includeRefund = null,
                              bool? @includeSubscription = null,
                              bool? @includeSupport = null,
                              bool? @includeTax = null,
                              bool? @includeUpfront = null,
                              bool? @useAmortized = null,
                              bool? @useBlended = null)
            {
                @IncludeCredit = @includeCredit;
                @IncludeDiscount = @includeDiscount;
                @IncludeOtherSubscription = @includeOtherSubscription;
                @IncludeRecurring = @includeRecurring;
                @IncludeRefund = @includeRefund;
                @IncludeSubscription = @includeSubscription;
                @IncludeSupport = @includeSupport;
                @IncludeTax = @includeTax;
                @IncludeUpfront = @includeUpfront;
                @UseAmortized = @useAmortized;
                @UseBlended = @useBlended;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "include_credit", @out: false, min: 0, max: 1)]
            public bool? @IncludeCredit { get; }

            [nterraform.Core.TerraformProperty(name: "include_discount", @out: false, min: 0, max: 1)]
            public bool? @IncludeDiscount { get; }

            [nterraform.Core.TerraformProperty(name: "include_other_subscription", @out: false, min: 0, max: 1)]
            public bool? @IncludeOtherSubscription { get; }

            [nterraform.Core.TerraformProperty(name: "include_recurring", @out: false, min: 0, max: 1)]
            public bool? @IncludeRecurring { get; }

            [nterraform.Core.TerraformProperty(name: "include_refund", @out: false, min: 0, max: 1)]
            public bool? @IncludeRefund { get; }

            [nterraform.Core.TerraformProperty(name: "include_subscription", @out: false, min: 0, max: 1)]
            public bool? @IncludeSubscription { get; }

            [nterraform.Core.TerraformProperty(name: "include_support", @out: false, min: 0, max: 1)]
            public bool? @IncludeSupport { get; }

            [nterraform.Core.TerraformProperty(name: "include_tax", @out: false, min: 0, max: 1)]
            public bool? @IncludeTax { get; }

            [nterraform.Core.TerraformProperty(name: "include_upfront", @out: false, min: 0, max: 1)]
            public bool? @IncludeUpfront { get; }

            [nterraform.Core.TerraformProperty(name: "use_amortized", @out: false, min: 0, max: 1)]
            public bool? @UseAmortized { get; }

            [nterraform.Core.TerraformProperty(name: "use_blended", @out: false, min: 0, max: 1)]
            public bool? @UseBlended { get; }
        }

        public aws_budgets_budget(string @budgetType,
                                  string @limitAmount,
                                  string @limitUnit,
                                  string @timePeriodStart,
                                  string @timeUnit,
                                  cost_types[] @costTypes = null,
                                  string @timePeriodEnd = null)
        {
            @BudgetType = @budgetType;
            @LimitAmount = @limitAmount;
            @LimitUnit = @limitUnit;
            @TimePeriodStart = @timePeriodStart;
            @TimeUnit = @timeUnit;
            @CostTypes = @costTypes;
            @TimePeriodEnd = @timePeriodEnd;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "budget_type", @out: false, min: 1, max: 1)]
        public string @BudgetType { get; }

        [nterraform.Core.TerraformProperty(name: "limit_amount", @out: false, min: 1, max: 1)]
        public string @LimitAmount { get; }

        [nterraform.Core.TerraformProperty(name: "limit_unit", @out: false, min: 1, max: 1)]
        public string @LimitUnit { get; }

        [nterraform.Core.TerraformProperty(name: "time_period_start", @out: false, min: 1, max: 1)]
        public string @TimePeriodStart { get; }

        [nterraform.Core.TerraformProperty(name: "time_unit", @out: false, min: 1, max: 1)]
        public string @TimeUnit { get; }

        [nterraform.Core.TerraformProperty(name: "account_id", @out: true, min: 0, max: 1)]
        public string @AccountId { get; }

        [nterraform.Core.TerraformProperty(name: "cost_filters", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @CostFilters { get; }

        [nterraform.Core.TerraformProperty(name: "cost_types", @out: false, min: 0, max: 1)]
        public cost_types[] @CostTypes { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: true, min: 0, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "name_prefix", @out: true, min: 0, max: 1)]
        public string @NamePrefix { get; }

        [nterraform.Core.TerraformProperty(name: "time_period_end", @out: false, min: 0, max: 1)]
        public string @TimePeriodEnd { get; }
    }

}
