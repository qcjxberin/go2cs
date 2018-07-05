﻿//******************************************************************************************************
//  ScannerBase_Expression.cs - Gbtc
//
//  Copyright © 2018, Grid Protection Alliance.  All Rights Reserved.
//
//  Licensed to the Grid Protection Alliance (GPA) under one or more contributor license agreements. See
//  the NOTICE file distributed with this work for additional information regarding copyright ownership.
//  The GPA licenses this file to you under the MIT License (MIT), the "License"; you may not use this
//  file except in compliance with the License. You may obtain a copy of the License at:
//
//      http://opensource.org/licenses/MIT
//
//  Unless agreed to in writing, the subject software distributed under the License is distributed on an
//  "AS-IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. Refer to the
//  License for the specific language governing permissions and limitations.
//
//  Code Modification History:
//  ----------------------------------------------------------------------------------------------------
//  05/03/2018 - J. Ritchie Carroll
//       Generated original version of source code.
//
//******************************************************************************************************

using System.Diagnostics;
using static go2cs.Common;

namespace go2cs
{
    public partial class ScannerBase
    {
        // Stack handlers:
        //  expressionList (required)
        //  expressionStmt (required)
        //  sendStmt (required)
        //  incDecStmt (required)
        //  defer (required)
        //  ifStmt (required)
        //  exprSwitchStmt (optional)
        //  recvStmt (required)
        //  forClause (optional)
        //  rangeClause (required)
        //  goStmt (required)
        //  arrayLength (required)
        //  operand (optional)
        //  key (optional)
        //  element (optional)
        //  index (required)
        //  slice (optional)
        //  expression (optional)
        //  conversion (required)
        protected readonly ParseTreeValues<string> Expressions = new ParseTreeValues<string>();

        public override void EnterExpression(GolangParser.ExpressionContext context)
        {
            string expression = context.GetText();
            char firstChar = expression[0];

            if (firstChar == '"' || firstChar == '`')
                Expressions[context] = $"\"{ToStringLiteral(expression)}\"";
            else
                Expressions[context] = expression;
        }

        // TODO: Focus on getting primaryExpr working, and build out from there
        public override void ExitPrimaryExpr(GolangParser.PrimaryExprContext context)
        {
        }

        public override void ExitExpression(GolangParser.ExpressionContext context)
        {
            if (context.expression()?.Length == 2)
            {                
                // TODO: BINARY_OP - convert "^" to " ~" and "&^" to "& ~"
                Debug.WriteLine($"{context.expression(0).GetText()} {context.children[1].GetText()} {context.expression(1).GetText()}");
            }
        }

        public override void ExitBasicLit(GolangParser.BasicLitContext context)
        {
            if (context.IMAGINARY_LIT() != null)
            {
                // TODO: Convert expression like "1.2i" to "i(1.2)"
            }
            //else if (context.RUNE_LIT())
        }
    }
}