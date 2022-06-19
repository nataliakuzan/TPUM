/* ========================================================================
 * Copyright (c) 2005-2021 The OPC Foundation, Inc. All rights reserved.
 *
 * OPC Foundation MIT License 1.00
 *
 * Permission is hereby granted, free of charge, to any person
 * obtaining a copy of this software and associated documentation
 * files (the "Software"), to deal in the Software without
 * restriction, including without limitation the rights to use,
 * copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the
 * Software is furnished to do so, subject to the following
 * conditions:
 *
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
 * OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
 * WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.
 *
 * The complete license agreement can be found here:
 * http://opcfoundation.org/License/MIT/1.00/
 * ======================================================================*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua;

namespace Shop
{
    #region DataType Identifiers
    /// <summary>
    /// A class that declares constants for all DataTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class DataTypes
    {
        /// <summary>
        /// The identifier for the TypeDTO DataType.
        /// </summary>
        public const uint TypeDTO = 42;
    }
    #endregion

    #region Method Identifiers
    /// <summary>
    /// A class that declares constants for all Methods in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Methods
    {
        /// <summary>
        /// The identifier for the ProductDTO_DecreaseQuantity Method.
        /// </summary>
        public const uint ProductDTO_DecreaseQuantity = 29;

        /// <summary>
        /// The identifier for the OrderDTO_GetTotalItemQuantity Method.
        /// </summary>
        public const uint OrderDTO_GetTotalItemQuantity = 36;

        /// <summary>
        /// The identifier for the OrderDTO_GetTotalPrice Method.
        /// </summary>
        public const uint OrderDTO_GetTotalPrice = 37;

        /// <summary>
        /// The identifier for the BasketItemDTO_GetTotalPrice Method.
        /// </summary>
        public const uint BasketItemDTO_GetTotalPrice = 41;
    }
    #endregion

    #region Object Identifiers
    /// <summary>
    /// A class that declares constants for all Objects in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Objects
    {
        /// <summary>
        /// The identifier for the OrderDTO_Items Object.
        /// </summary>
        public const uint OrderDTO_Items = 32;

        /// <summary>
        /// The identifier for the BasketItemDTO_BasketItemProduct Object.
        /// </summary>
        public const uint BasketItemDTO_BasketItemProduct = 39;
    }
    #endregion

    #region ObjectType Identifiers
    /// <summary>
    /// A class that declares constants for all ObjectTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypes
    {
        /// <summary>
        /// The identifier for the ProductDTO ObjectType.
        /// </summary>
        public const uint ProductDTO = 1;

        /// <summary>
        /// The identifier for the OrderDTO ObjectType.
        /// </summary>
        public const uint OrderDTO = 30;

        /// <summary>
        /// The identifier for the BasketItemDTO ObjectType.
        /// </summary>
        public const uint BasketItemDTO = 38;
    }
    #endregion

    #region Variable Identifiers
    /// <summary>
    /// A class that declares constants for all Variables in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Variables
    {
        /// <summary>
        /// The identifier for the ProductDTO_ProductId Variable.
        /// </summary>
        public const uint ProductDTO_ProductId = 2;

        /// <summary>
        /// The identifier for the ProductDTO_ProductName Variable.
        /// </summary>
        public const uint ProductDTO_ProductName = 3;

        /// <summary>
        /// The identifier for the ProductDTO_ProductPrice Variable.
        /// </summary>
        public const uint ProductDTO_ProductPrice = 4;

        /// <summary>
        /// The identifier for the ProductDTO_ProductQuantity Variable.
        /// </summary>
        public const uint ProductDTO_ProductQuantity = 5;

        /// <summary>
        /// The identifier for the ProductDTO_ProductType Variable.
        /// </summary>
        public const uint ProductDTO_ProductType = 6;

        /// <summary>
        /// The identifier for the OrderDTO_OrderId Variable.
        /// </summary>
        public const uint OrderDTO_OrderId = 31;

        /// <summary>
        /// The identifier for the OrderDTO_ClientName Variable.
        /// </summary>
        public const uint OrderDTO_ClientName = 33;

        /// <summary>
        /// The identifier for the OrderDTO_ClientLastName Variable.
        /// </summary>
        public const uint OrderDTO_ClientLastName = 34;

        /// <summary>
        /// The identifier for the OrderDTO_ClientAddress Variable.
        /// </summary>
        public const uint OrderDTO_ClientAddress = 35;

        /// <summary>
        /// The identifier for the BasketItemDTO_BasketItemQuantity Variable.
        /// </summary>
        public const uint BasketItemDTO_BasketItemQuantity = 40;

        /// <summary>
        /// The identifier for the cas_BinarySchema Variable.
        /// </summary>
        public const uint cas_BinarySchema = 21;

        /// <summary>
        /// The identifier for the cas_BinarySchema_NamespaceUri Variable.
        /// </summary>
        public const uint cas_BinarySchema_NamespaceUri = 23;

        /// <summary>
        /// The identifier for the cas_BinarySchema_Deprecated Variable.
        /// </summary>
        public const uint cas_BinarySchema_Deprecated = 24;

        /// <summary>
        /// The identifier for the cas_XmlSchema Variable.
        /// </summary>
        public const uint cas_XmlSchema = 25;

        /// <summary>
        /// The identifier for the cas_XmlSchema_NamespaceUri Variable.
        /// </summary>
        public const uint cas_XmlSchema_NamespaceUri = 27;

        /// <summary>
        /// The identifier for the cas_XmlSchema_Deprecated Variable.
        /// </summary>
        public const uint cas_XmlSchema_Deprecated = 28;
    }
    #endregion

    #region DataType Node Identifiers
    /// <summary>
    /// A class that declares constants for all DataTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class DataTypeIds
    {
        /// <summary>
        /// The identifier for the TypeDTO DataType.
        /// </summary>
        public static readonly ExpandedNodeId TypeDTO = new ExpandedNodeId(DataTypes.TypeDTO, Namespaces.cas);
    }
    #endregion

    #region Method Node Identifiers
    /// <summary>
    /// A class that declares constants for all Methods in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class MethodIds
    {
        /// <summary>
        /// The identifier for the ProductDTO_DecreaseQuantity Method.
        /// </summary>
        public static readonly ExpandedNodeId ProductDTO_DecreaseQuantity = new ExpandedNodeId(Methods.ProductDTO_DecreaseQuantity, Namespaces.cas);

        /// <summary>
        /// The identifier for the OrderDTO_GetTotalItemQuantity Method.
        /// </summary>
        public static readonly ExpandedNodeId OrderDTO_GetTotalItemQuantity = new ExpandedNodeId(Methods.OrderDTO_GetTotalItemQuantity, Namespaces.cas);

        /// <summary>
        /// The identifier for the OrderDTO_GetTotalPrice Method.
        /// </summary>
        public static readonly ExpandedNodeId OrderDTO_GetTotalPrice = new ExpandedNodeId(Methods.OrderDTO_GetTotalPrice, Namespaces.cas);

        /// <summary>
        /// The identifier for the BasketItemDTO_GetTotalPrice Method.
        /// </summary>
        public static readonly ExpandedNodeId BasketItemDTO_GetTotalPrice = new ExpandedNodeId(Methods.BasketItemDTO_GetTotalPrice, Namespaces.cas);
    }
    #endregion

    #region Object Node Identifiers
    /// <summary>
    /// A class that declares constants for all Objects in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectIds
    {
        /// <summary>
        /// The identifier for the OrderDTO_Items Object.
        /// </summary>
        public static readonly ExpandedNodeId OrderDTO_Items = new ExpandedNodeId(Objects.OrderDTO_Items, Namespaces.cas);

        /// <summary>
        /// The identifier for the BasketItemDTO_BasketItemProduct Object.
        /// </summary>
        public static readonly ExpandedNodeId BasketItemDTO_BasketItemProduct = new ExpandedNodeId(Objects.BasketItemDTO_BasketItemProduct, Namespaces.cas);
    }
    #endregion

    #region ObjectType Node Identifiers
    /// <summary>
    /// A class that declares constants for all ObjectTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypeIds
    {
        /// <summary>
        /// The identifier for the ProductDTO ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId ProductDTO = new ExpandedNodeId(ObjectTypes.ProductDTO, Namespaces.cas);

        /// <summary>
        /// The identifier for the OrderDTO ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId OrderDTO = new ExpandedNodeId(ObjectTypes.OrderDTO, Namespaces.cas);

        /// <summary>
        /// The identifier for the BasketItemDTO ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId BasketItemDTO = new ExpandedNodeId(ObjectTypes.BasketItemDTO, Namespaces.cas);
    }
    #endregion

    #region Variable Node Identifiers
    /// <summary>
    /// A class that declares constants for all Variables in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableIds
    {
        /// <summary>
        /// The identifier for the ProductDTO_ProductId Variable.
        /// </summary>
        public static readonly ExpandedNodeId ProductDTO_ProductId = new ExpandedNodeId(Variables.ProductDTO_ProductId, Namespaces.cas);

        /// <summary>
        /// The identifier for the ProductDTO_ProductName Variable.
        /// </summary>
        public static readonly ExpandedNodeId ProductDTO_ProductName = new ExpandedNodeId(Variables.ProductDTO_ProductName, Namespaces.cas);

        /// <summary>
        /// The identifier for the ProductDTO_ProductPrice Variable.
        /// </summary>
        public static readonly ExpandedNodeId ProductDTO_ProductPrice = new ExpandedNodeId(Variables.ProductDTO_ProductPrice, Namespaces.cas);

        /// <summary>
        /// The identifier for the ProductDTO_ProductQuantity Variable.
        /// </summary>
        public static readonly ExpandedNodeId ProductDTO_ProductQuantity = new ExpandedNodeId(Variables.ProductDTO_ProductQuantity, Namespaces.cas);

        /// <summary>
        /// The identifier for the ProductDTO_ProductType Variable.
        /// </summary>
        public static readonly ExpandedNodeId ProductDTO_ProductType = new ExpandedNodeId(Variables.ProductDTO_ProductType, Namespaces.cas);

        /// <summary>
        /// The identifier for the OrderDTO_OrderId Variable.
        /// </summary>
        public static readonly ExpandedNodeId OrderDTO_OrderId = new ExpandedNodeId(Variables.OrderDTO_OrderId, Namespaces.cas);

        /// <summary>
        /// The identifier for the OrderDTO_ClientName Variable.
        /// </summary>
        public static readonly ExpandedNodeId OrderDTO_ClientName = new ExpandedNodeId(Variables.OrderDTO_ClientName, Namespaces.cas);

        /// <summary>
        /// The identifier for the OrderDTO_ClientLastName Variable.
        /// </summary>
        public static readonly ExpandedNodeId OrderDTO_ClientLastName = new ExpandedNodeId(Variables.OrderDTO_ClientLastName, Namespaces.cas);

        /// <summary>
        /// The identifier for the OrderDTO_ClientAddress Variable.
        /// </summary>
        public static readonly ExpandedNodeId OrderDTO_ClientAddress = new ExpandedNodeId(Variables.OrderDTO_ClientAddress, Namespaces.cas);

        /// <summary>
        /// The identifier for the BasketItemDTO_BasketItemQuantity Variable.
        /// </summary>
        public static readonly ExpandedNodeId BasketItemDTO_BasketItemQuantity = new ExpandedNodeId(Variables.BasketItemDTO_BasketItemQuantity, Namespaces.cas);

        /// <summary>
        /// The identifier for the cas_BinarySchema Variable.
        /// </summary>
        public static readonly ExpandedNodeId cas_BinarySchema = new ExpandedNodeId(Variables.cas_BinarySchema, Namespaces.cas);

        /// <summary>
        /// The identifier for the cas_BinarySchema_NamespaceUri Variable.
        /// </summary>
        public static readonly ExpandedNodeId cas_BinarySchema_NamespaceUri = new ExpandedNodeId(Variables.cas_BinarySchema_NamespaceUri, Namespaces.cas);

        /// <summary>
        /// The identifier for the cas_BinarySchema_Deprecated Variable.
        /// </summary>
        public static readonly ExpandedNodeId cas_BinarySchema_Deprecated = new ExpandedNodeId(Variables.cas_BinarySchema_Deprecated, Namespaces.cas);

        /// <summary>
        /// The identifier for the cas_XmlSchema Variable.
        /// </summary>
        public static readonly ExpandedNodeId cas_XmlSchema = new ExpandedNodeId(Variables.cas_XmlSchema, Namespaces.cas);

        /// <summary>
        /// The identifier for the cas_XmlSchema_NamespaceUri Variable.
        /// </summary>
        public static readonly ExpandedNodeId cas_XmlSchema_NamespaceUri = new ExpandedNodeId(Variables.cas_XmlSchema_NamespaceUri, Namespaces.cas);

        /// <summary>
        /// The identifier for the cas_XmlSchema_Deprecated Variable.
        /// </summary>
        public static readonly ExpandedNodeId cas_XmlSchema_Deprecated = new ExpandedNodeId(Variables.cas_XmlSchema_Deprecated, Namespaces.cas);
    }
    #endregion

    #region BrowseName Declarations
    /// <summary>
    /// Declares all of the BrowseNames used in the Model Design.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class BrowseNames
    {
        /// <summary>
        /// The BrowseName for the BasketItemDTO component.
        /// </summary>
        public const string BasketItemDTO = "BasketItemDTO";

        /// <summary>
        /// The BrowseName for the BasketItemProduct component.
        /// </summary>
        public const string BasketItemProduct = "BasketItemProduct";

        /// <summary>
        /// The BrowseName for the BasketItemQuantity component.
        /// </summary>
        public const string BasketItemQuantity = "BasketItemQuantity";

        /// <summary>
        /// The BrowseName for the cas_BinarySchema component.
        /// </summary>
        public const string cas_BinarySchema = "";

        /// <summary>
        /// The BrowseName for the cas_XmlSchema component.
        /// </summary>
        public const string cas_XmlSchema = "";

        /// <summary>
        /// The BrowseName for the ClientAddress component.
        /// </summary>
        public const string ClientAddress = "ClientAddress";

        /// <summary>
        /// The BrowseName for the ClientLastName component.
        /// </summary>
        public const string ClientLastName = "ClientLastName";

        /// <summary>
        /// The BrowseName for the ClientName component.
        /// </summary>
        public const string ClientName = "ClientName";

        /// <summary>
        /// The BrowseName for the DecreaseQuantity component.
        /// </summary>
        public const string DecreaseQuantity = "DecreaseQuantity";

        /// <summary>
        /// The BrowseName for the GetTotalItemQuantity component.
        /// </summary>
        public const string GetTotalItemQuantity = "GetTotalItemQuantity";

        /// <summary>
        /// The BrowseName for the GetTotalPrice component.
        /// </summary>
        public const string GetTotalPrice = "GetTotalPrice";

        /// <summary>
        /// The BrowseName for the Items component.
        /// </summary>
        public const string Items = "Items";

        /// <summary>
        /// The BrowseName for the OrderDTO component.
        /// </summary>
        public const string OrderDTO = "OrderDTO";

        /// <summary>
        /// The BrowseName for the OrderId component.
        /// </summary>
        public const string OrderId = "OrderId";

        /// <summary>
        /// The BrowseName for the ProductDTO component.
        /// </summary>
        public const string ProductDTO = "ProductDTO";

        /// <summary>
        /// The BrowseName for the ProductId component.
        /// </summary>
        public const string ProductId = "ProductId";

        /// <summary>
        /// The BrowseName for the ProductName component.
        /// </summary>
        public const string ProductName = "ProductName";

        /// <summary>
        /// The BrowseName for the ProductPrice component.
        /// </summary>
        public const string ProductPrice = "ProductPrice";

        /// <summary>
        /// The BrowseName for the ProductQuantity component.
        /// </summary>
        public const string ProductQuantity = "ProductQuantity";

        /// <summary>
        /// The BrowseName for the ProductType component.
        /// </summary>
        public const string ProductType = "ProductType";

        /// <summary>
        /// The BrowseName for the TypeDTO component.
        /// </summary>
        public const string TypeDTO = "TypeDTO";
    }
    #endregion

    #region Namespace Declarations
    /// <summary>
    /// Defines constants for all namespaces referenced by the model design.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Namespaces
    {
        /// <summary>
        /// The URI for the cas namespace (.NET code namespace is '').
        /// </summary>
        public const string cas = "http://cas.eu/UA/CommServer/";

        /// <summary>
        /// The URI for the OpcUa namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUa = "http://opcfoundation.org/UA/";

        /// <summary>
        /// The URI for the OpcUaXsd namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUaXsd = "http://opcfoundation.org/UA/2008/02/Types.xsd";
    }
    #endregion
}