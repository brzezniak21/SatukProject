//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.13.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:/Users/Msi/RiderProjects/Satuk/Satuk/Satuk.g4 by ANTLR 4.13.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="SatukParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.13.1")]
[System.CLSCompliant(false)]
public interface ISatukVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="SatukParser.program"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitProgram([NotNull] SatukParser.ProgramContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SatukParser.prog"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitProg([NotNull] SatukParser.ProgContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>display</c>
	/// labeled alternative in <see cref="SatukParser.print"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDisplay([NotNull] SatukParser.DisplayContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>displayString</c>
	/// labeled alternative in <see cref="SatukParser.print_content"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDisplayString([NotNull] SatukParser.DisplayStringContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>print_variable</c>
	/// labeled alternative in <see cref="SatukParser.print_content"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPrint_variable([NotNull] SatukParser.Print_variableContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>print_char</c>
	/// labeled alternative in <see cref="SatukParser.print_content"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPrint_char([NotNull] SatukParser.Print_charContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>print_int</c>
	/// labeled alternative in <see cref="SatukParser.print_content"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPrint_int([NotNull] SatukParser.Print_intContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>print_float</c>
	/// labeled alternative in <see cref="SatukParser.print_content"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPrint_float([NotNull] SatukParser.Print_floatContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>print_bool</c>
	/// labeled alternative in <see cref="SatukParser.print_content"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPrint_bool([NotNull] SatukParser.Print_boolContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>print_arithmetics</c>
	/// labeled alternative in <see cref="SatukParser.print_content"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPrint_arithmetics([NotNull] SatukParser.Print_arithmeticsContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>print_logicalInstructions</c>
	/// labeled alternative in <see cref="SatukParser.print_content"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPrint_logicalInstructions([NotNull] SatukParser.Print_logicalInstructionsContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>ArAss</c>
	/// labeled alternative in <see cref="SatukParser.assignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitArAss([NotNull] SatukParser.ArAssContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>boolAss</c>
	/// labeled alternative in <see cref="SatukParser.assignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBoolAss([NotNull] SatukParser.BoolAssContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>stringAss</c>
	/// labeled alternative in <see cref="SatukParser.assignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStringAss([NotNull] SatukParser.StringAssContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>charAss</c>
	/// labeled alternative in <see cref="SatukParser.assignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitCharAss([NotNull] SatukParser.CharAssContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>intConstAss</c>
	/// labeled alternative in <see cref="SatukParser.assignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIntConstAss([NotNull] SatukParser.IntConstAssContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>varDynAss</c>
	/// labeled alternative in <see cref="SatukParser.assignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVarDynAss([NotNull] SatukParser.VarDynAssContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>floatConstAss</c>
	/// labeled alternative in <see cref="SatukParser.assignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFloatConstAss([NotNull] SatukParser.FloatConstAssContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>classAss</c>
	/// labeled alternative in <see cref="SatukParser.assignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitClassAss([NotNull] SatukParser.ClassAssContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SatukParser.assignment_function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAssignment_function([NotNull] SatukParser.Assignment_functionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>numberArithm</c>
	/// labeled alternative in <see cref="SatukParser.arithmetics"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNumberArithm([NotNull] SatukParser.NumberArithmContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>parenArithm</c>
	/// labeled alternative in <see cref="SatukParser.arithmetics"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParenArithm([NotNull] SatukParser.ParenArithmContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>opArithm</c>
	/// labeled alternative in <see cref="SatukParser.arithmetics"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOpArithm([NotNull] SatukParser.OpArithmContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>incVar</c>
	/// labeled alternative in <see cref="SatukParser.mutators"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIncVar([NotNull] SatukParser.IncVarContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>decVar</c>
	/// labeled alternative in <see cref="SatukParser.mutators"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDecVar([NotNull] SatukParser.DecVarContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>notLogical</c>
	/// labeled alternative in <see cref="SatukParser.logical_instructions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNotLogical([NotNull] SatukParser.NotLogicalContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>opLogical</c>
	/// labeled alternative in <see cref="SatukParser.logical_instructions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitOpLogical([NotNull] SatukParser.OpLogicalContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>varLogical</c>
	/// labeled alternative in <see cref="SatukParser.logical_instructions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVarLogical([NotNull] SatukParser.VarLogicalContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SatukParser.if_statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIf_statement([NotNull] SatukParser.If_statementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SatukParser.loop"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLoop([NotNull] SatukParser.LoopContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SatukParser.functions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunctions([NotNull] SatukParser.FunctionsContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SatukParser.function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunction([NotNull] SatukParser.FunctionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>construct</c>
	/// labeled alternative in <see cref="SatukParser.constructor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitConstruct([NotNull] SatukParser.ConstructContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SatukParser.return"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitReturn([NotNull] SatukParser.ReturnContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SatukParser.class"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitClass([NotNull] SatukParser.ClassContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SatukParser.execute_function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExecute_function([NotNull] SatukParser.Execute_functionContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>funcVoid</c>
	/// labeled alternative in <see cref="SatukParser.void_function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFuncVoid([NotNull] SatukParser.FuncVoidContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>funcInt</c>
	/// labeled alternative in <see cref="SatukParser.int_function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFuncInt([NotNull] SatukParser.FuncIntContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>funcFloat</c>
	/// labeled alternative in <see cref="SatukParser.float_function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFuncFloat([NotNull] SatukParser.FuncFloatContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>funcString</c>
	/// labeled alternative in <see cref="SatukParser.string_function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFuncString([NotNull] SatukParser.FuncStringContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>funcChar</c>
	/// labeled alternative in <see cref="SatukParser.char_function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFuncChar([NotNull] SatukParser.FuncCharContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>funcBool</c>
	/// labeled alternative in <see cref="SatukParser.bool_function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFuncBool([NotNull] SatukParser.FuncBoolContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>funcVar</c>
	/// labeled alternative in <see cref="SatukParser.variable_function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFuncVar([NotNull] SatukParser.FuncVarContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="SatukParser.void_return"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVoid_return([NotNull] SatukParser.Void_returnContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>retInt</c>
	/// labeled alternative in <see cref="SatukParser.int_return"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRetInt([NotNull] SatukParser.RetIntContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>retFloat</c>
	/// labeled alternative in <see cref="SatukParser.float_return"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRetFloat([NotNull] SatukParser.RetFloatContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>retString</c>
	/// labeled alternative in <see cref="SatukParser.string_return"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRetString([NotNull] SatukParser.RetStringContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>retChar</c>
	/// labeled alternative in <see cref="SatukParser.char_return"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRetChar([NotNull] SatukParser.RetCharContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>retBool</c>
	/// labeled alternative in <see cref="SatukParser.bool_return"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRetBool([NotNull] SatukParser.RetBoolContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>retVar</c>
	/// labeled alternative in <see cref="SatukParser.variable_return"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRetVar([NotNull] SatukParser.RetVarContext context);
}
