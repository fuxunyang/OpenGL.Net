
// Copyright (C) 2015-2017 Luca Piccioni
// 
// This library is free software; you can redistribute it and/or
// modify it under the terms of the GNU Lesser General Public
// License as published by the Free Software Foundation; either
// version 2.1 of the License, or (at your option) any later version.
// 
// This library is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public
// License along with this library; if not, write to the Free Software
// Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301
// USA

#pragma warning disable 649, 1572, 1573

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace OpenGL
{
	public partial class Gl
	{
		/// <summary>
		/// [GL] Value of GL_PIXEL_COUNTER_BITS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_occlusion_query")]
		public const int PIXEL_COUNTER_BITS_NV = 0x8864;

		/// <summary>
		/// [GL] Value of GL_CURRENT_OCCLUSION_QUERY_ID_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_occlusion_query")]
		public const int CURRENT_OCCLUSION_QUERY_ID_NV = 0x8865;

		/// <summary>
		/// [GL] Value of GL_PIXEL_COUNT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_occlusion_query")]
		public const int PIXEL_COUNT_NV = 0x8866;

		/// <summary>
		/// [GL] Value of GL_PIXEL_COUNT_AVAILABLE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_occlusion_query")]
		public const int PIXEL_COUNT_AVAILABLE_NV = 0x8867;

		/// <summary>
		/// Binding for glGenOcclusionQueriesNV.
		/// </summary>
		/// <param name="ids">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_occlusion_query")]
		public static void GenOcclusionQueriesNV(UInt32[] ids)
		{
			unsafe {
				fixed (UInt32* p_ids = ids)
				{
					Debug.Assert(Delegates.pglGenOcclusionQueriesNV != null, "pglGenOcclusionQueriesNV not implemented");
					Delegates.pglGenOcclusionQueriesNV((Int32)ids.Length, p_ids);
					LogCommand("glGenOcclusionQueriesNV", null, ids.Length, ids					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGenOcclusionQueriesNV.
		/// </summary>
		[RequiredByFeature("GL_NV_occlusion_query")]
		public static UInt32 GenOcclusionQueriesNV()
		{
			UInt32[] retValue = new UInt32[1];
			GenOcclusionQueriesNV(retValue);
			return (retValue[0]);
		}

		/// <summary>
		/// Binding for glDeleteOcclusionQueriesNV.
		/// </summary>
		/// <param name="ids">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_occlusion_query")]
		public static void DeleteOcclusionQueriesNV(params UInt32[] ids)
		{
			unsafe {
				fixed (UInt32* p_ids = ids)
				{
					Debug.Assert(Delegates.pglDeleteOcclusionQueriesNV != null, "pglDeleteOcclusionQueriesNV not implemented");
					Delegates.pglDeleteOcclusionQueriesNV((Int32)ids.Length, p_ids);
					LogCommand("glDeleteOcclusionQueriesNV", null, ids.Length, ids					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glIsOcclusionQueryNV.
		/// </summary>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_occlusion_query")]
		public static bool IsOcclusionQueryNV(UInt32 id)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsOcclusionQueryNV != null, "pglIsOcclusionQueryNV not implemented");
			retValue = Delegates.pglIsOcclusionQueryNV(id);
			LogCommand("glIsOcclusionQueryNV", retValue, id			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for glBeginOcclusionQueryNV.
		/// </summary>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_occlusion_query")]
		public static void BeginOcclusionQueryNV(UInt32 id)
		{
			Debug.Assert(Delegates.pglBeginOcclusionQueryNV != null, "pglBeginOcclusionQueryNV not implemented");
			Delegates.pglBeginOcclusionQueryNV(id);
			LogCommand("glBeginOcclusionQueryNV", null, id			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glEndOcclusionQueryNV.
		/// </summary>
		[RequiredByFeature("GL_NV_occlusion_query")]
		public static void EndOcclusionQueryNV()
		{
			Debug.Assert(Delegates.pglEndOcclusionQueryNV != null, "pglEndOcclusionQueryNV not implemented");
			Delegates.pglEndOcclusionQueryNV();
			LogCommand("glEndOcclusionQueryNV", null			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetOcclusionQueryivNV.
		/// </summary>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_occlusion_query")]
		public static void GetOcclusionQueryNV(UInt32 id, Int32 pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetOcclusionQueryivNV != null, "pglGetOcclusionQueryivNV not implemented");
					Delegates.pglGetOcclusionQueryivNV(id, pname, p_params);
					LogCommand("glGetOcclusionQueryivNV", null, id, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetOcclusionQueryuivNV.
		/// </summary>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_occlusion_query")]
		public static void GetOcclusionQueryuivNV(UInt32 id, Int32 pname, [Out] UInt32[] @params)
		{
			unsafe {
				fixed (UInt32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetOcclusionQueryuivNV != null, "pglGetOcclusionQueryuivNV not implemented");
					Delegates.pglGetOcclusionQueryuivNV(id, pname, p_params);
					LogCommand("glGetOcclusionQueryuivNV", null, id, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGenOcclusionQueriesNV", ExactSpelling = true)]
			internal extern static unsafe void glGenOcclusionQueriesNV(Int32 n, UInt32* ids);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glDeleteOcclusionQueriesNV", ExactSpelling = true)]
			internal extern static unsafe void glDeleteOcclusionQueriesNV(Int32 n, UInt32* ids);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glIsOcclusionQueryNV", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal extern static bool glIsOcclusionQueryNV(UInt32 id);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glBeginOcclusionQueryNV", ExactSpelling = true)]
			internal extern static void glBeginOcclusionQueryNV(UInt32 id);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glEndOcclusionQueryNV", ExactSpelling = true)]
			internal extern static void glEndOcclusionQueryNV();

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetOcclusionQueryivNV", ExactSpelling = true)]
			internal extern static unsafe void glGetOcclusionQueryivNV(UInt32 id, Int32 pname, Int32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetOcclusionQueryuivNV", ExactSpelling = true)]
			internal extern static unsafe void glGetOcclusionQueryuivNV(UInt32 id, Int32 pname, UInt32* @params);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_NV_occlusion_query")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGenOcclusionQueriesNV(Int32 n, UInt32* ids);

			[ThreadStatic]
			internal static glGenOcclusionQueriesNV pglGenOcclusionQueriesNV;

			[RequiredByFeature("GL_NV_occlusion_query")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glDeleteOcclusionQueriesNV(Int32 n, UInt32* ids);

			[ThreadStatic]
			internal static glDeleteOcclusionQueriesNV pglDeleteOcclusionQueriesNV;

			[RequiredByFeature("GL_NV_occlusion_query")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool glIsOcclusionQueryNV(UInt32 id);

			[ThreadStatic]
			internal static glIsOcclusionQueryNV pglIsOcclusionQueryNV;

			[RequiredByFeature("GL_NV_occlusion_query")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBeginOcclusionQueryNV(UInt32 id);

			[ThreadStatic]
			internal static glBeginOcclusionQueryNV pglBeginOcclusionQueryNV;

			[RequiredByFeature("GL_NV_occlusion_query")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glEndOcclusionQueryNV();

			[ThreadStatic]
			internal static glEndOcclusionQueryNV pglEndOcclusionQueryNV;

			[RequiredByFeature("GL_NV_occlusion_query")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetOcclusionQueryivNV(UInt32 id, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetOcclusionQueryivNV pglGetOcclusionQueryivNV;

			[RequiredByFeature("GL_NV_occlusion_query")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetOcclusionQueryuivNV(UInt32 id, Int32 pname, UInt32* @params);

			[ThreadStatic]
			internal static glGetOcclusionQueryuivNV pglGetOcclusionQueryuivNV;

		}
	}

}
