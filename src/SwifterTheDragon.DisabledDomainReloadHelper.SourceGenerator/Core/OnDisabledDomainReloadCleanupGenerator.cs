// Copyright SwifterTheDragon, and the SwifterTheDragon.DisabledDomainReloadHelper contributors, 2025. All Rights Reserved.
// SPDX-License-Identifier: MIT

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using SwifterTheDragon.DisabledDomainReloadHelper.Markers.Core;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;

namespace SwifterTheDragon.DisabledDomainReloadHelper.SourceGenerator.Core
{
    /// <include
    /// file='../../docs/SwifterTheDragon.DisabledDomainReloadHelper.SourceGenerator.xml'
    /// path='Assembly[@name="SwifterTheDragon.DisabledDomainReloadHelper.SourceGenerator"]/Namespace[@name="Core"]/Type[@name="OnDisabledDomainReloadCleanupGenerator"]/Description/*'/>
    [Generator]
#pragma warning disable CA1812 // Avoid uninstantiated internal classes
    internal sealed class OnDisabledDomainReloadCleanupGenerator : IIncrementalGenerator
#pragma warning restore CA1812 // Avoid uninstantiated internal classes
    {
        #region Nested Types
        #region EquatableList<T> Legal Attribution
        /* Solely the type EquatableList<T>,
         * and its implementation originate from:
        https://github.com/dotnet/roslyn/blob/e6d1a8c05334b36f2c9ecb515f1e35b137e16adb/docs/features/incremental-generators.cookbook.md?plain=1#L808C5-L848C2
        and is therefore subject to the following license:

The MIT License (MIT)

Copyright (c) .NET Foundation and Contributors

All rights reserved.
Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
         */
        #endregion EquatableList<T> Legal Attribution
        /// <include
        /// file='../../docs/SwifterTheDragon.DisabledDomainReloadHelper.SourceGenerator.xml'
        /// path='Assembly[@name="SwifterTheDragon.DisabledDomainReloadHelper.SourceGenerator"]/Namespace[@name="Core"]/Type[@name="OnDisabledDomainReloadCleanupGenerator"]/Type[@name="EquatableList`1"]/Description/*'/>
        private sealed class EquatableList<T> : List<T>
        {
            #region Methods
            /// <include
            /// file='../../docs/SwifterTheDragon.DisabledDomainReloadHelper.SourceGenerator.xml'
            /// path='Assembly[@name="SwifterTheDragon.DisabledDomainReloadHelper.SourceGenerator"]/Namespace[@name="Core"]/Type[@name="OnDisabledDomainReloadCleanupGenerator"]/Type[@name="EquatableList`1"]/Method[@name="op_Equality(SwifterTheDragon.DisabledDomainReloadHelper.SourceGenerator.Core.OnDisabledDomainReloadCleanupGenerator.EquatableList`1,SwifterTheDragon.DisabledDomainReloadHelper.SourceGenerator.Core.OnDisabledDomainReloadCleanupGenerator.EquatableList`1)"]/*'/>
            public static bool operator ==(EquatableList<T> list1, EquatableList<T> list2)
            {
                return ReferenceEquals(
                    objA: list1,
                    objB: list2)
                    || (!(list1 is null)
                        && !(list2 is null)
                        && list1.Equals(
                            obj: list2));
            }
            /// <include
            /// file='../../docs/SwifterTheDragon.DisabledDomainReloadHelper.SourceGenerator.xml'
            /// path='Assembly[@name="SwifterTheDragon.DisabledDomainReloadHelper.SourceGenerator"]/Namespace[@name="Core"]/Type[@name="OnDisabledDomainReloadCleanupGenerator"]/Type[@name="EquatableList`1"]/Method[@name="op_Inequality(SwifterTheDragon.DisabledDomainReloadHelper.SourceGenerator.Core.OnDisabledDomainReloadCleanupGenerator.EquatableList`1,SwifterTheDragon.DisabledDomainReloadHelper.SourceGenerator.Core.OnDisabledDomainReloadCleanupGenerator.EquatableList`1)"]/*'/>
            public static bool operator !=(EquatableList<T> list1, EquatableList<T> list2)
            {
                return !(list1 == list2);
            }
            /// <include
            /// file='../../docs/SwifterTheDragon.DisabledDomainReloadHelper.SourceGenerator.xml'
            /// path='Assembly[@name="SwifterTheDragon.DisabledDomainReloadHelper.SourceGenerator"]/Namespace[@name="Core"]/Type[@name="OnDisabledDomainReloadCleanupGenerator"]/Type[@name="EquatableList`1"]/Method[@name="Equals(System.Object)"]/*'/>
            public override bool Equals(
                object obj)
            {
                return Equals(
                    other: obj as EquatableList<T>);
            }
            /// <include
            /// file='../../docs/SwifterTheDragon.DisabledDomainReloadHelper.SourceGenerator.xml'
            /// path='Assembly[@name="SwifterTheDragon.DisabledDomainReloadHelper.SourceGenerator"]/Namespace[@name="Core"]/Type[@name="OnDisabledDomainReloadCleanupGenerator"]/Type[@name="EquatableList`1"]/Method[@name="GetHashCode"]/*'/>
            public override int GetHashCode()
            {
                return this.Select(
                    selector: (item) =>
                    {
                        return item?.GetHashCode() ?? 0;
                    })
                    .Aggregate(
                        func: (x, y) =>
                        {
                            return x ^ y;
                        });
            }
            /// <include
            /// file='../../docs/SwifterTheDragon.DisabledDomainReloadHelper.SourceGenerator.xml'
            /// path='Assembly[@name="SwifterTheDragon.DisabledDomainReloadHelper.SourceGenerator"]/Namespace[@name="Core"]/Type[@name="OnDisabledDomainReloadCleanupGenerator"]/Type[@name="EquatableList`1"]/Method[@name="Equals(System.Collections.Generic.IList`1)"]/*'/>
            internal bool Equals(
                IList<T> other)
            {
                if (other is null || Count != other.Count)
                {
                    return false;
                }
                for (int index = 0; index < Count; index++)
                {
                    if (!EqualityComparer<T>.Default.Equals(
                        x: this[index],
                        y: other[index]))
                    {
                        return false;
                    }
                }
                return true;
            }
            #endregion Methods
        }
        #endregion Nested Types
        #region Fields & Properties
        /// <include
        /// file='../../docs/SwifterTheDragon.DisabledDomainReloadHelper.SourceGenerator.xml'
        /// path='Assembly[@name="SwifterTheDragon.DisabledDomainReloadHelper.SourceGenerator"]/Namespace[@name="Core"]/Type[@name="OnDisabledDomainReloadCleanupGenerator"]/Property[@name="MarkerAttributeName"]/*'/>
        private static string MarkerAttributeName
        {
            get
            {
                return "SwifterTheDragon.DisabledDomainReloadHelper.Markers.Core.OnCleanupDisabledDomainReloadsAttribute";
            }
        }
        /// <include
        /// file='../../docs/SwifterTheDragon.DisabledDomainReloadHelper.SourceGenerator.xml'
        /// path='Assembly[@name="SwifterTheDragon.DisabledDomainReloadHelper.SourceGenerator"]/Namespace[@name="Core"]/Type[@name="OnDisabledDomainReloadCleanupGenerator"]/Property[@name="ToolName"]/*'/>
        private static string ToolName
        {
            get
            {
                return typeof(OnDisabledDomainReloadCleanupGenerator).Assembly.GetName().Name;
            }
        }
        /// <include
        /// file='../../docs/SwifterTheDragon.DisabledDomainReloadHelper.SourceGenerator.xml'
        /// path='Assembly[@name="SwifterTheDragon.DisabledDomainReloadHelper.SourceGenerator"]/Namespace[@name="Core"]/Type[@name="OnDisabledDomainReloadCleanupGenerator"]/Property[@name="ToolVersion"]/*'/>
        private static string ToolVersion
        {
            get
            {
                return FileVersionInfo.GetVersionInfo(typeof(OnDisabledDomainReloadCleanupGenerator).Assembly.Location).ProductVersion;
            }
        }
        /// <include
        /// file='../../docs/SwifterTheDragon.DisabledDomainReloadHelper.SourceGenerator.xml'
        /// path='Assembly[@name="SwifterTheDragon.DisabledDomainReloadHelper.SourceGenerator"]/Namespace[@name="Core"]/Type[@name="OnDisabledDomainReloadCleanupGenerator"]/Property[@name="GeneratorName"]/*'/>
        private static string GeneratorName
        {
            get
            {
                return nameof(OnDisabledDomainReloadCleanupGenerator);
            }
        }
        #endregion Fields & Properties
        #region Methods
        public void Initialize(
            IncrementalGeneratorInitializationContext context)
        {
            IncrementalValuesProvider<(
                string generatedNamespace,
                EquatableList<string> generatedTypeNames,
                string generatedMethodName,
                CleanupDisabledDomainReloadPhases phase)> pipeline = context.SyntaxProvider.ForAttributeWithMetadataName(
                    fullyQualifiedMetadataName: MarkerAttributeName,
                    predicate: SyntaxNodePredicate,
                    transform: Transform);
            IncrementalValuesProvider<(
                string generatedNamespace,
                EquatableList<string> generatedTypeNames,
                string generatedMethodName,
                CleanupDisabledDomainReloadPhases phase)> pipeline2 = pipeline.Where(
                    predicate: PipelinePredicate);
            context.RegisterSourceOutput(
                source: pipeline2,
                action: RegisterSourceOutput);
        }
        /// <include
        /// file='../../docs/SwifterTheDragon.DisabledDomainReloadHelper.SourceGenerator.xml'
        /// path='Assembly[@name="SwifterTheDragon.DisabledDomainReloadHelper.SourceGenerator"]/Namespace[@name="Core"]/Type[@name="OnDisabledDomainReloadCleanupGenerator"]/Method[@name="SyntaxNodePredicate(Microsoft.CodeAnalysis.SyntaxNode,System.Threading.CancellationToken)"]/*'/>
        private static bool SyntaxNodePredicate(
            SyntaxNode syntaxNode,
            CancellationToken cancellationToken)
        {
            return syntaxNode is BaseMethodDeclarationSyntax;
        }
        /// <include
        /// file='../../docs/SwifterTheDragon.DisabledDomainReloadHelper.SourceGenerator.xml'
        /// path='Assembly[@name="SwifterTheDragon.DisabledDomainReloadHelper.SourceGenerator"]/Namespace[@name="Core"]/Type[@name="OnDisabledDomainReloadCleanupGenerator"]/Method[@name="Transform(Microsoft.CodeAnalysis.GeneratorAttributeSyntaxContext,System.Threading.CancellationToken)"]/*'/>
        private static (
            string generatedNamespace,
            EquatableList<string> generatedTypeNames,
            string generatedMethodName,
            CleanupDisabledDomainReloadPhases phase)
        Transform(
            GeneratorAttributeSyntaxContext context,
            CancellationToken cancellationToken)
        {
            INamedTypeSymbol containingType = context.TargetSymbol.ContainingType;
            string generatedNamespace = containingType.ContainingNamespace.ToDisplayString(
                format: SymbolDisplayFormat.FullyQualifiedFormat.WithGlobalNamespaceStyle(
                    style: SymbolDisplayGlobalNamespaceStyle.Omitted));
            var generatedTypeNames = new EquatableList<string>
            {
                containingType.Name
            };
            INamedTypeSymbol currentOuterType = containingType.ContainingType;
            if (currentOuterType != null)
            {
                do
                {
                    generatedTypeNames.Add(
                        item: currentOuterType.Name);
                    currentOuterType = currentOuterType.ContainingType;
                }
                while (currentOuterType != null);
                generatedTypeNames.Reverse();
            }
            string generatedMethodName = context.TargetSymbol.Name;
            var phase = (CleanupDisabledDomainReloadPhases)context.Attributes[0].ConstructorArguments[0].Value;
            return (
                generatedNamespace,
                generatedTypeNames,
                generatedMethodName,
                phase);
        }
        /// <include
        /// file='../../docs/SwifterTheDragon.DisabledDomainReloadHelper.SourceGenerator.xml'
        /// path='Assembly[@name="SwifterTheDragon.DisabledDomainReloadHelper.SourceGenerator"]/Namespace[@name="Core"]/Type[@name="OnDisabledDomainReloadCleanupGenerator"]/Method[@name="PipelinePredicate(System.ValueTuple{System.String,SwifterTheDragon.DisabledDomainReloadHelper.SourceGenerator.Core.OnDisabledDomainReloadCleanupGenerator.EquatableList{System.String},System.String,SwifterTheDragon.DisabledDomainReloadHelper.Markers.Core.CleanupDisabledDomainReloadPhases})"]/*'/>
        private static bool PipelinePredicate(
            (
                string generatedNamespace,
                EquatableList<string> generatedTypeNames,
                string generatedMethodName,
                CleanupDisabledDomainReloadPhases phase) model)
        {
            return Enum.IsDefined(
                enumType: typeof(CleanupDisabledDomainReloadPhases),
                value: model.phase)
                && !model.phase.Equals(
                    obj: default);
        }
        /// <include
        /// file='../../docs/SwifterTheDragon.DisabledDomainReloadHelper.SourceGenerator.xml'
        /// path='Assembly[@name="SwifterTheDragon.DisabledDomainReloadHelper.SourceGenerator"]/Namespace[@name="Core"]/Type[@name="OnDisabledDomainReloadCleanupGenerator"]/Method[@name="RegisterSourceOutput(Microsoft.CodeAnalysis.SourceProductionContext,System.ValueTuple{System.String,SwifterTheDragon.DisabledDomainReloadHelper.SourceGenerator.Core.OnDisabledDomainReloadCleanupGenerator.EquatableList{System.String},System.String,SwifterTheDragon.DisabledDomainReloadHelper.Markers.Core.CleanupDisabledDomainReloadPhases})"]/*'/>
        private static void RegisterSourceOutput(
            SourceProductionContext context,
            (
                string generatedNamespace,
                EquatableList<string> generatedTypeNames,
                string generatedMethodName,
                CleanupDisabledDomainReloadPhases phase) model)
        {
            StringBuilder typeNameIncludingNestingBuilder = new StringBuilder()
                .Append(
                    value: model.generatedTypeNames[0]);
            if (model.generatedTypeNames.Count > 1)
            {
                var remainingTypeNames = new List<string>(
                    collection: model.generatedTypeNames);
                remainingTypeNames.RemoveAt(
                    index: 0);
                foreach (string typeName in remainingTypeNames)
                {
                    typeNameIncludingNestingBuilder.Append(
                        value: '.')
                        .Append(
                            value: typeName);
                }
            }
            typeNameIncludingNestingBuilder.Append(
                value: '.')
                .Append(
                    value: model.generatedMethodName);
            string nonGlobalTargetMethodCodeReference = typeNameIncludingNestingBuilder.ToString();
            string uniqueIdentifier = nonGlobalTargetMethodCodeReference.Replace(
                oldChar: '.',
                newChar: '_');
            StringBuilder globalNamespaceToTargetMethodCodeReferenceBuilder = new StringBuilder()
                .Append(
                    value: "global::");
            if (!string.IsNullOrWhiteSpace(
                value: model.generatedNamespace))
            {
                globalNamespaceToTargetMethodCodeReferenceBuilder.Append(
                    value: model.generatedNamespace)
                    .Append(
                        value: '.');
            }
            globalNamespaceToTargetMethodCodeReferenceBuilder.Append(
                value: nonGlobalTargetMethodCodeReference);
            string globalNamespaceToTargetMethodCodeReference = globalNamespaceToTargetMethodCodeReferenceBuilder.ToString();
            var sourceBuilder = new IndentationManager();
            const string BeginSummary = "/// <summary>";
            const string EndSummary = "/// </summary>";
            sourceBuilder.AppendWithoutWhiteSpace(
                input: BuildAutoGeneratedCodeHeader());
            sourceBuilder.AppendLineWithWhiteSpace(
                input: "#region Editor Only");
            sourceBuilder.AppendLineWithWhiteSpace(
                input: "#if UNITY_EDITOR");
            sourceBuilder.AppendLineWithWhiteSpace(
                input: "using System.CodeDom.Compiler;");
            sourceBuilder.AppendLineWithWhiteSpace(
                input: "using System.Reflection;");
            sourceBuilder.AppendLineWithWhiteSpace(
                input: "using UnityEditor;");
            sourceBuilder.AppendLine();
            if (!string.IsNullOrWhiteSpace(
                value: model.generatedNamespace))
            {
                sourceBuilder.AppendWithoutWhiteSpace(
                    input: "namespace ");
                sourceBuilder.AppendLineWithoutWhiteSpace(
                    input: model.generatedNamespace);
                sourceBuilder.OpenBlock();
            }
            sourceBuilder.AppendLineWithWhiteSpace(
                input: BeginSummary);
            sourceBuilder.AppendLineWithWhiteSpace(
                input: "/// Invokes");
            sourceBuilder.AppendWithWhiteSpace(
                input: "/// <c><see cref=\"");
            sourceBuilder.AppendWithoutWhiteSpace(
                input: globalNamespaceToTargetMethodCodeReference);
            sourceBuilder.AppendLineWithoutWhiteSpace(
                input: "\" /></c>");
            sourceBuilder.AppendWithWhiteSpace(
                input: "/// upon ");
            if (model.phase is CleanupDisabledDomainReloadPhases.OnExitPlayMode)
            {
                sourceBuilder.AppendWithoutWhiteSpace(
                    input: "exiting");
            }
            else
            {
                sourceBuilder.AppendWithoutWhiteSpace(
                    input: "entering");
            }
            sourceBuilder.AppendLineWithoutWhiteSpace(
                input: " play mode.");
            sourceBuilder.AppendLineWithWhiteSpace(
                input: EndSummary);
            sourceBuilder.AppendLineWithWhiteSpace(
                input: "[GeneratedCode(");
            sourceBuilder.IncrementIndentation();
            sourceBuilder.AppendWithWhiteSpace(
                input: "tool: \"");
            sourceBuilder.AppendWithoutWhiteSpace(
                input: ToolName);
            sourceBuilder.AppendLineWithoutWhiteSpace(
                input: "\",");
            sourceBuilder.AppendWithWhiteSpace(
                input: "version: \"");
            sourceBuilder.AppendWithoutWhiteSpace(
                input: ToolVersion);
            sourceBuilder.AppendLineWithoutWhiteSpace(
                input: "\")]");
            sourceBuilder.DecrementIndentation();
            sourceBuilder.AppendWithWhiteSpace(
                input: "internal static class ");
            sourceBuilder.AppendLineWithoutWhiteSpace(
                input: uniqueIdentifier);
            sourceBuilder.OpenBlock();
            sourceBuilder.AppendLineWithWhiteSpace(
                input: "#region Methods");
            sourceBuilder.AppendLineWithWhiteSpace(
                input: BeginSummary);
            sourceBuilder.AppendLineWithWhiteSpace(
                input: "/// A callback for");
            sourceBuilder.AppendLineWithWhiteSpace(
                input: "/// <c><see cref=\"InitializeOnEnterPlayModeAttribute\" /></c>");
            sourceBuilder.AppendWithWhiteSpace(
                input: "/// that ");
            if (model.phase is CleanupDisabledDomainReloadPhases.OnExitPlayMode)
            {
                sourceBuilder.AppendLineWithoutWhiteSpace(
                    input: "subscribes");
                sourceBuilder.AppendLineWithWhiteSpace(
                    input: "/// <c><see cref=\"OnPlayModeStateChanged\" /></c>");
                sourceBuilder.AppendLineWithWhiteSpace(
                    input: "/// to");
                sourceBuilder.AppendLineWithWhiteSpace(
                    input: "/// <c><see cref=\"EditorApplication.playModeStateChanged\" /></c>,");
            }
            else
            {
                sourceBuilder.AppendLineWithoutWhiteSpace(
                    input: "invokes");
                sourceBuilder.AppendLineWithWhiteSpace(
                    input: "/// <c><see cref=\"InvokeTargetMethod\" /></c>,");
            }
            sourceBuilder.AppendLineWithWhiteSpace(
                input: "/// if <c><paramref name=\"options\" /></c> has");
            sourceBuilder.AppendLineWithWhiteSpace(
                input: "/// <c><see cref=\"EnterPlayModeOptions.DisableDomainReload\" /></c>.");
            sourceBuilder.AppendLineWithWhiteSpace(
                input: EndSummary);
            sourceBuilder.AppendLineWithWhiteSpace(
                input: "/// <param name=\"options\">");
            sourceBuilder.AppendLineWithWhiteSpace(
                input: "/// The current <c><see cref=\"EnterPlayModeOptions\" /></c>.");
            sourceBuilder.AppendLineWithWhiteSpace(
                input: "/// </param>");
            sourceBuilder.AppendLineWithWhiteSpace(
                input: "[InitializeOnEnterPlayMode]");
            sourceBuilder.AppendLineWithWhiteSpace(
                input: "private static void OnInitialiseOnEnterPlayMode(");
            sourceBuilder.IncrementIndentation();
            sourceBuilder.AppendLineWithWhiteSpace(
                input: "EnterPlayModeOptions options)");
            sourceBuilder.DecrementIndentation();
            sourceBuilder.OpenBlock();
            sourceBuilder.AppendLineWithWhiteSpace(
                input: "if (!options.HasFlag(");
            sourceBuilder.IncrementIndentation();
            sourceBuilder.AppendLineWithWhiteSpace(
                input: "flag: EnterPlayModeOptions.DisableDomainReload))");
            sourceBuilder.DecrementIndentation();
            sourceBuilder.OpenBlock();
            sourceBuilder.AppendLineWithWhiteSpace(
                input: "return;");
            sourceBuilder.CloseBlock();
            if (model.phase is CleanupDisabledDomainReloadPhases.OnExitPlayMode)
            {
                sourceBuilder.AppendLineWithWhiteSpace(
                    input: "EditorApplication.playModeStateChanged -= OnPlayModeStateChanged;");
                sourceBuilder.AppendLineWithWhiteSpace(
                    input: "EditorApplication.playModeStateChanged += OnPlayModeStateChanged;");
                sourceBuilder.CloseBlock();
                sourceBuilder.AppendLineWithWhiteSpace(
                    input: BeginSummary);
                sourceBuilder.AppendLineWithWhiteSpace(
                    input: "/// A callback for");
                sourceBuilder.AppendLineWithWhiteSpace(
                    input: "/// <c><see cref=\"EditorApplication.playModeStateChanged\" /></c>");
                sourceBuilder.AppendLineWithWhiteSpace(
                    input: "/// that invokes <c><see cref=\"InvokeTargetMethod\" /></c>");
                sourceBuilder.AppendLineWithWhiteSpace(
                    input: "/// if <c><paramref name=\"state\" /></c> is");
                sourceBuilder.AppendLineWithWhiteSpace(
                    input: "/// <c><see cref=\"PlayModeStateChange.ExitingPlayMode\" /></c>.");
                sourceBuilder.AppendLineWithWhiteSpace(
                    input: EndSummary);
                sourceBuilder.AppendLineWithWhiteSpace(
                    input: "private static void OnPlayModeStateChanged(");
                sourceBuilder.IncrementIndentation();
                sourceBuilder.AppendLineWithWhiteSpace(
                    input: "PlayModeStateChange state)");
                sourceBuilder.DecrementIndentation();
                sourceBuilder.OpenBlock();
                sourceBuilder.AppendLineWithWhiteSpace(
                    input: "if (state is not PlayModeStateChange.ExitingPlayMode)");
                sourceBuilder.OpenBlock();
                sourceBuilder.AppendLineWithWhiteSpace(
                    input: "return;");
                sourceBuilder.CloseBlock();
                sourceBuilder.AppendLineWithWhiteSpace(
                    input: "EditorApplication.playModeStateChanged -= OnPlayModeStateChanged;");
                sourceBuilder.AppendLineWithWhiteSpace(
                    input: "OnExitingPlayMode();");
                sourceBuilder.CloseBlock();
                sourceBuilder.AppendLineWithWhiteSpace(
                    input: BeginSummary);
                sourceBuilder.AppendLineWithWhiteSpace(
                    input: "/// A callback for when");
                sourceBuilder.AppendLineWithWhiteSpace(
                    input: "/// <c><see cref=\"OnPlayModeStateChanged\" /></c>");
                sourceBuilder.AppendLineWithWhiteSpace(
                    input: "/// is called with");
                sourceBuilder.AppendLineWithWhiteSpace(
                    input: "/// <c><see cref=\"PlayModeStateChange.ExitingPlayMode\" /></c>.");
                sourceBuilder.AppendLineWithWhiteSpace(
                    input: EndSummary);
                sourceBuilder.AppendLineWithWhiteSpace(
                    input: "private static void OnExitingPlayMode()");
                sourceBuilder.OpenBlock();
                sourceBuilder.AppendLineWithWhiteSpace(
                    input: "InvokeTargetMethod();");
            }
            else
            {
                sourceBuilder.AppendLineWithWhiteSpace(
                    input: "InvokeTargetMethod();");
            }
            sourceBuilder.CloseBlock();
            sourceBuilder.AppendLineWithWhiteSpace(
                input: BeginSummary);
            sourceBuilder.AppendLineWithWhiteSpace(
                input: "/// Invokes");
            sourceBuilder.AppendWithWhiteSpace(
                input: "/// <c><see cref=\"");
            sourceBuilder.AppendWithoutWhiteSpace(
                input: globalNamespaceToTargetMethodCodeReference);
            sourceBuilder.AppendLineWithoutWhiteSpace(
                input: "\" /></c>.");
            sourceBuilder.AppendLineWithWhiteSpace(
                input: EndSummary);
            sourceBuilder.AppendLineWithWhiteSpace(
                input: "private static void InvokeTargetMethod()");
            sourceBuilder.OpenBlock();
            sourceBuilder.AppendWithWhiteSpace(
                input: "_ = typeof(");
            sourceBuilder.AppendWithoutWhiteSpace(
                input: model.generatedTypeNames[0]);
            sourceBuilder.AppendLineWithoutWhiteSpace(
                input: ")");
            sourceBuilder.IncrementIndentation();
            if (model.generatedTypeNames.Count > 1)
            {
                var remainingTargetTypes = new List<string>(
                    collection: model.generatedTypeNames);
                remainingTargetTypes.RemoveAt(
                    index: 0);
                foreach (string currentNestedTypeName in remainingTargetTypes)
                {
                    sourceBuilder.AppendLineWithWhiteSpace(
                        input: ".GetNestedType(");
                    sourceBuilder.IncrementIndentation();
                    sourceBuilder.AppendWithWhiteSpace(
                        input: "name: \"");
                    sourceBuilder.AppendWithoutWhiteSpace(
                        input: currentNestedTypeName);
                    sourceBuilder.AppendLineWithoutWhiteSpace(
                        input: "\",");
                    sourceBuilder.AppendLineWithWhiteSpace(
                        input: "bindingAttr: BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance)");
                    sourceBuilder.DecrementIndentation();
                }
            }
            sourceBuilder.AppendLineWithWhiteSpace(
                input: ".GetMethod(");
            sourceBuilder.IncrementIndentation();
            sourceBuilder.AppendWithWhiteSpace(
                input: "name: \"");
            sourceBuilder.AppendWithoutWhiteSpace(
                input: model.generatedMethodName);
            sourceBuilder.AppendLineWithoutWhiteSpace(
                input: "\",");
            sourceBuilder.AppendLineWithWhiteSpace(
                input: "bindingAttr: BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static)");
            sourceBuilder.DecrementIndentation();
            sourceBuilder.AppendLineWithWhiteSpace(
                input: ".Invoke(");
            sourceBuilder.IncrementIndentation();
            sourceBuilder.AppendLineWithWhiteSpace(
                input: "obj: null,");
            sourceBuilder.AppendLineWithWhiteSpace(
                input: "parameters: null);");
            sourceBuilder.DecrementIndentation();
            sourceBuilder.DecrementIndentation();
            sourceBuilder.CloseBlock();
            sourceBuilder.AppendLineWithWhiteSpace(
                input: "#endregion Methods");
            sourceBuilder.CloseBlock();
            if (!string.IsNullOrWhiteSpace(
                value: model.generatedNamespace))
            {
                sourceBuilder.CloseBlock();
            }
            sourceBuilder.AppendLineWithWhiteSpace(
                input: "#endif");
            sourceBuilder.AppendLineWithWhiteSpace(
                input: "#endregion Editor Only");
            sourceBuilder.AppendWithoutWhiteSpace(
                input: BuildAutoGeneratedCodeFooter());
            var sourceText = SourceText.From(
                text: sourceBuilder.Output(),
                encoding: Encoding.UTF8);
            context.AddSource(
                hintName: uniqueIdentifier
                    + ".Generated.cs",
                sourceText: sourceText);
        }
        /// <include
        /// file='../../docs/SwifterTheDragon.DisabledDomainReloadHelper.SourceGenerator.xml'
        /// path='Assembly[@name="SwifterTheDragon.DisabledDomainReloadHelper.SourceGenerator"]/Namespace[@name="Core"]/Type[@name="OnDisabledDomainReloadCleanupGenerator"]/Method[@name="BuildAutoGeneratedCodeHeader"]/*'/>
        private static string BuildAutoGeneratedCodeHeader()
        {
            var headerBuilder = new StringBuilder();
            void AppendFullLine()
            {
                headerBuilder.Append(
                    value: "// ---------------------------")
                    .AppendLine(
                        value: "--------------------------------------------------");
            }
            AppendFullLine();
            headerBuilder.AppendLine(
                value: "// <auto-generated>")
                .Append(
                    value: "//     This code was generated by: \"")
                .Append(
                    value: ToolName)
                .AppendLine(
                    value: "\"")
                .Append(
                    value: "//     Version: ")
                .AppendLine(
                    value: ToolVersion)
                .AppendLine(
                    value: "//")
                .AppendLine(
                    value: "//     Changes to this file may cause incorrect behaviour and will be lost if")
                .AppendLine(
                    value: "//     the code is regenerated.")
                .AppendLine(
                    value: "// </auto-generated>");
            AppendFullLine();
            headerBuilder.AppendLine()
                .AppendLine(
                    value: "// Copyright SwifterTheDragon, and the SwifterTheDragon.DisabledDomainReloadHelper contributors, 2025. All Rights Reserved.")
                .AppendLine(
                    value: "// SPDX-License-Identifier: MIT")
                .AppendLine();
            return headerBuilder.ToString();
        }
        /// <include
        /// file='../../docs/SwifterTheDragon.DisabledDomainReloadHelper.SourceGenerator.xml'
        /// path='Assembly[@name="SwifterTheDragon.DisabledDomainReloadHelper.SourceGenerator"]/Namespace[@name="Core"]/Type[@name="OnDisabledDomainReloadCleanupGenerator"]/Method[@name="BuildAutoGeneratedCodeFooter"]/*'/>
        private static string BuildAutoGeneratedCodeFooter()
        {
            StringBuilder footerBuilder = new StringBuilder()
                .AppendLine()
                .Append(
                    value: "// Generated by \"")
                .Append(
                    value: ToolName)
                .Append(
                    value: "\"'s \"")
                .Append(
                    value: GeneratorName)
                .AppendLine(
                    value: "\" class.");
            return footerBuilder.ToString();
        }
        #endregion Methods
    }
}
