using System;
using System.Collections.Immutable;
using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Diagnostics;

namespace CustomAnalyzer
{
    [DiagnosticAnalyzer(LanguageNames.CSharp)]
    public class CustomAnalyzerAnalyzer : DiagnosticAnalyzer
    {
        public const string DiagnosticId = "NoHardcode";

        private const string Title = "Properties shouldn't have a hardcoded value.";
        private const string MessageFormat = "Remove hardcoded value.";
        private const string Description = "No Hardcode";
        private const string Category = "Usage";

        private static DiagnosticDescriptor Rule = new DiagnosticDescriptor(DiagnosticId, Title, MessageFormat, Category, DiagnosticSeverity.Warning, isEnabledByDefault: true, description: Description);

        public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics { get { return ImmutableArray.Create(Rule); } }

        public override void Initialize(AnalysisContext context)
        {
            context.RegisterSyntaxNodeAction(AnalyzeNodeProperty, SyntaxKind.PropertyDeclaration);
        }

        private void AnalyzeNodeProperty(SyntaxNodeAnalysisContext context)
        {
            var localDeclaration = (PropertyDeclarationSyntax)context.Node;

            if(localDeclaration != null)
            {
                if(localDeclaration.Initializer == null)
                {
                    return ;
                }

                context.ReportDiagnostic(Diagnostic.Create(Rule, context.Node.GetLocation()));
            }

            return ;
        }
    }
}
