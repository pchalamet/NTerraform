using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_budgets_budget")]
    public sealed class aws_budgets_budget : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "cost_types")]
        public sealed class cost_types : nterraform.structure
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

            [nterraform.TerraformProperty(name: "include_credit", @out: false, min: 0, max: 1)]
            public bool? @IncludeCredit { get; }

            [nterraform.TerraformProperty(name: "include_discount", @out: false, min: 0, max: 1)]
            public bool? @IncludeDiscount { get; }

            [nterraform.TerraformProperty(name: "include_other_subscription", @out: false, min: 0, max: 1)]
            public bool? @IncludeOtherSubscription { get; }

            [nterraform.TerraformProperty(name: "include_recurring", @out: false, min: 0, max: 1)]
            public bool? @IncludeRecurring { get; }

            [nterraform.TerraformProperty(name: "include_refund", @out: false, min: 0, max: 1)]
            public bool? @IncludeRefund { get; }

            [nterraform.TerraformProperty(name: "include_subscription", @out: false, min: 0, max: 1)]
            public bool? @IncludeSubscription { get; }

            [nterraform.TerraformProperty(name: "include_support", @out: false, min: 0, max: 1)]
            public bool? @IncludeSupport { get; }

            [nterraform.TerraformProperty(name: "include_tax", @out: false, min: 0, max: 1)]
            public bool? @IncludeTax { get; }

            [nterraform.TerraformProperty(name: "include_upfront", @out: false, min: 0, max: 1)]
            public bool? @IncludeUpfront { get; }

            [nterraform.TerraformProperty(name: "use_amortized", @out: false, min: 0, max: 1)]
            public bool? @UseAmortized { get; }

            [nterraform.TerraformProperty(name: "use_blended", @out: false, min: 0, max: 1)]
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

        [nterraform.TerraformProperty(name: "budget_type", @out: false, min: 1, max: 1)]
        public string @BudgetType { get; }

        [nterraform.TerraformProperty(name: "limit_amount", @out: false, min: 1, max: 1)]
        public string @LimitAmount { get; }

        [nterraform.TerraformProperty(name: "limit_unit", @out: false, min: 1, max: 1)]
        public string @LimitUnit { get; }

        [nterraform.TerraformProperty(name: "time_period_start", @out: false, min: 1, max: 1)]
        public string @TimePeriodStart { get; }

        [nterraform.TerraformProperty(name: "time_unit", @out: false, min: 1, max: 1)]
        public string @TimeUnit { get; }

        [nterraform.TerraformProperty(name: "account_id", @out: true, min: 0, max: 1)]
        public string @AccountId { get; }

        [nterraform.TerraformProperty(name: "cost_filters", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @CostFilters { get; }

        [nterraform.TerraformProperty(name: "cost_types", @out: false, min: 0, max: 1)]
        public cost_types[] @CostTypes { get; }

        [nterraform.TerraformProperty(name: "name", @out: true, min: 0, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "name_prefix", @out: true, min: 0, max: 1)]
        public string @NamePrefix { get; }

        [nterraform.TerraformProperty(name: "time_period_end", @out: false, min: 0, max: 1)]
        public string @TimePeriodEnd { get; }
    }

}
