
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
		/// [GL] Value of GL_UNPACK_COMPRESSED_BLOCK_WIDTH symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_compressed_texture_pixel_storage", Api = "gl|glcore")]
		public const int UNPACK_COMPRESSED_BLOCK_WIDTH = 0x9127;

		/// <summary>
		/// [GL] Value of GL_UNPACK_COMPRESSED_BLOCK_HEIGHT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_compressed_texture_pixel_storage", Api = "gl|glcore")]
		public const int UNPACK_COMPRESSED_BLOCK_HEIGHT = 0x9128;

		/// <summary>
		/// [GL] Value of GL_UNPACK_COMPRESSED_BLOCK_DEPTH symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_compressed_texture_pixel_storage", Api = "gl|glcore")]
		public const int UNPACK_COMPRESSED_BLOCK_DEPTH = 0x9129;

		/// <summary>
		/// [GL] Value of GL_UNPACK_COMPRESSED_BLOCK_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_compressed_texture_pixel_storage", Api = "gl|glcore")]
		public const int UNPACK_COMPRESSED_BLOCK_SIZE = 0x912A;

		/// <summary>
		/// [GL] Value of GL_PACK_COMPRESSED_BLOCK_WIDTH symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_compressed_texture_pixel_storage", Api = "gl|glcore")]
		public const int PACK_COMPRESSED_BLOCK_WIDTH = 0x912B;

		/// <summary>
		/// [GL] Value of GL_PACK_COMPRESSED_BLOCK_HEIGHT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_compressed_texture_pixel_storage", Api = "gl|glcore")]
		public const int PACK_COMPRESSED_BLOCK_HEIGHT = 0x912C;

		/// <summary>
		/// [GL] Value of GL_PACK_COMPRESSED_BLOCK_DEPTH symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_compressed_texture_pixel_storage", Api = "gl|glcore")]
		public const int PACK_COMPRESSED_BLOCK_DEPTH = 0x912D;

		/// <summary>
		/// [GL] Value of GL_PACK_COMPRESSED_BLOCK_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_compressed_texture_pixel_storage", Api = "gl|glcore")]
		public const int PACK_COMPRESSED_BLOCK_SIZE = 0x912E;

		/// <summary>
		/// [GL] Value of GL_NUM_SAMPLE_COUNTS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_internalformat_query", Api = "gl|glcore")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		public const int NUM_SAMPLE_COUNTS = 0x9380;

		/// <summary>
		/// [GL4] Gl.Get: data returns one value, the minimum alignment in basic machine units of pointers returned fromGl.MapBuffer 
		/// and Gl.MapBufferRange. This value must be a power of two and must be at least 64.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_map_buffer_alignment", Api = "gl|glcore")]
		public const int MIN_MAP_BUFFER_ALIGNMENT = 0x90BC;

		/// <summary>
		/// <para>
		/// [GL4] Gl.GetProgramInterface: The query is targeted at the set of active atomic counter buffer binding points within 
		/// program.
		/// </para>
		/// <para>
		/// [GLES3.2] Gl.GetProgramInterface: The query is targeted at the set of active atomic counter buffer binding points within 
		/// program.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
		[RequiredByFeature("GL_ARB_shader_atomic_counters", Api = "gl|glcore")]
		public const int ATOMIC_COUNTER_BUFFER = 0x92C0;

		/// <summary>
		/// [GL] Value of GL_ATOMIC_COUNTER_BUFFER_BINDING symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_atomic_counters", Api = "gl|glcore")]
		public const int ATOMIC_COUNTER_BUFFER_BINDING = 0x92C1;

		/// <summary>
		/// [GL] Value of GL_ATOMIC_COUNTER_BUFFER_START symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_atomic_counters", Api = "gl|glcore")]
		public const int ATOMIC_COUNTER_BUFFER_START = 0x92C2;

		/// <summary>
		/// [GL] Value of GL_ATOMIC_COUNTER_BUFFER_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_atomic_counters", Api = "gl|glcore")]
		public const int ATOMIC_COUNTER_BUFFER_SIZE = 0x92C3;

		/// <summary>
		/// [GL] Value of GL_ATOMIC_COUNTER_BUFFER_DATA_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_atomic_counters", Api = "gl|glcore")]
		public const int ATOMIC_COUNTER_BUFFER_DATA_SIZE = 0x92C4;

		/// <summary>
		/// [GL] Value of GL_ATOMIC_COUNTER_BUFFER_ACTIVE_ATOMIC_COUNTERS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_atomic_counters", Api = "gl|glcore")]
		public const int ATOMIC_COUNTER_BUFFER_ACTIVE_ATOMIC_COUNTERS = 0x92C5;

		/// <summary>
		/// [GL] Value of GL_ATOMIC_COUNTER_BUFFER_ACTIVE_ATOMIC_COUNTER_INDICES symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_atomic_counters", Api = "gl|glcore")]
		public const int ATOMIC_COUNTER_BUFFER_ACTIVE_ATOMIC_COUNTER_INDICES = 0x92C6;

		/// <summary>
		/// [GL] Value of GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_VERTEX_SHADER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_atomic_counters", Api = "gl|glcore")]
		public const int ATOMIC_COUNTER_BUFFER_REFERENCED_BY_VERTEX_SHADER = 0x92C7;

		/// <summary>
		/// [GL] Value of GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_TESS_CONTROL_SHADER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_atomic_counters", Api = "gl|glcore")]
		public const int ATOMIC_COUNTER_BUFFER_REFERENCED_BY_TESS_CONTROL_SHADER = 0x92C8;

		/// <summary>
		/// [GL] Value of GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_TESS_EVALUATION_SHADER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_atomic_counters", Api = "gl|glcore")]
		public const int ATOMIC_COUNTER_BUFFER_REFERENCED_BY_TESS_EVALUATION_SHADER = 0x92C9;

		/// <summary>
		/// [GL] Value of GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_GEOMETRY_SHADER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_atomic_counters", Api = "gl|glcore")]
		public const int ATOMIC_COUNTER_BUFFER_REFERENCED_BY_GEOMETRY_SHADER = 0x92CA;

		/// <summary>
		/// [GL] Value of GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_FRAGMENT_SHADER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_atomic_counters", Api = "gl|glcore")]
		public const int ATOMIC_COUNTER_BUFFER_REFERENCED_BY_FRAGMENT_SHADER = 0x92CB;

		/// <summary>
		/// [GL] Value of GL_MAX_VERTEX_ATOMIC_COUNTER_BUFFERS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_atomic_counters", Api = "gl|glcore")]
		public const int MAX_VERTEX_ATOMIC_COUNTER_BUFFERS = 0x92CC;

		/// <summary>
		/// [GLES3.2] Gl.Get: data returns a single value, the maximum number of atomic counter buffers that may be accessed by a 
		/// tesselation control shader.
		/// </summary>
		[AliasOf("GL_MAX_TESS_CONTROL_ATOMIC_COUNTER_BUFFERS_EXT")]
		[AliasOf("GL_MAX_TESS_CONTROL_ATOMIC_COUNTER_BUFFERS_OES")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_atomic_counters", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_tessellation_shader", Api = "gles2")]
		[RequiredByFeature("GL_OES_tessellation_shader", Api = "gles2")]
		public const int MAX_TESS_CONTROL_ATOMIC_COUNTER_BUFFERS = 0x92CD;

		/// <summary>
		/// [GLES3.2] Gl.Get: data returns a single value, the maximum number of atomic counter buffers that may be accessed by a 
		/// tesselation evaluation shader.
		/// </summary>
		[AliasOf("GL_MAX_TESS_EVALUATION_ATOMIC_COUNTER_BUFFERS_EXT")]
		[AliasOf("GL_MAX_TESS_EVALUATION_ATOMIC_COUNTER_BUFFERS_OES")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_atomic_counters", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_tessellation_shader", Api = "gles2")]
		[RequiredByFeature("GL_OES_tessellation_shader", Api = "gles2")]
		public const int MAX_TESS_EVALUATION_ATOMIC_COUNTER_BUFFERS = 0x92CE;

		/// <summary>
		/// [GLES3.2] Gl.Get: data returns a single value, the maximum number of atomic counter buffers that may be accessed by a 
		/// geometry shader.
		/// </summary>
		[AliasOf("GL_MAX_GEOMETRY_ATOMIC_COUNTER_BUFFERS_EXT")]
		[AliasOf("GL_MAX_GEOMETRY_ATOMIC_COUNTER_BUFFERS_OES")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_atomic_counters", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_geometry_shader", Api = "gles2")]
		[RequiredByFeature("GL_OES_geometry_shader", Api = "gles2")]
		public const int MAX_GEOMETRY_ATOMIC_COUNTER_BUFFERS = 0x92CF;

		/// <summary>
		/// [GLES3.2] Gl.Get: data returns a single value, the maximum number of atomic counter buffers that may be accessed by a 
		/// fragment shader. In GL ES 3.1, the minimum value is 0. in GL ES 3.2, the minimum value is 1.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_atomic_counters", Api = "gl|glcore")]
		public const int MAX_FRAGMENT_ATOMIC_COUNTER_BUFFERS = 0x92D0;

		/// <summary>
		/// [GL] Value of GL_MAX_COMBINED_ATOMIC_COUNTER_BUFFERS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_atomic_counters", Api = "gl|glcore")]
		public const int MAX_COMBINED_ATOMIC_COUNTER_BUFFERS = 0x92D1;

		/// <summary>
		/// <para>
		/// [GL4] Gl.Get: data returns a single value, the maximum number of atomic counters available to vertex shaders.
		/// </para>
		/// <para>
		/// [GLES3.2] Gl.Get: data returns a single value, the maximum number of atomic counters available to vertex shaders.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_atomic_counters", Api = "gl|glcore")]
		public const int MAX_VERTEX_ATOMIC_COUNTERS = 0x92D2;

		/// <summary>
		/// <para>
		/// [GL4] Gl.Get: data returns a single value, the maximum number of atomic counters available to tessellation control 
		/// shaders.
		/// </para>
		/// <para>
		/// [GLES3.2] Gl.Get: data returns a single value, the maximum number of atomic counters available to tessellation control 
		/// shaders.
		/// </para>
		/// </summary>
		[AliasOf("GL_MAX_TESS_CONTROL_ATOMIC_COUNTERS_EXT")]
		[AliasOf("GL_MAX_TESS_CONTROL_ATOMIC_COUNTERS_OES")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_atomic_counters", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_tessellation_shader", Api = "gles2")]
		[RequiredByFeature("GL_OES_tessellation_shader", Api = "gles2")]
		public const int MAX_TESS_CONTROL_ATOMIC_COUNTERS = 0x92D3;

		/// <summary>
		/// <para>
		/// [GL4] Gl.Get: data returns a single value, the maximum number of atomic counters available to tessellation evaluation 
		/// shaders.
		/// </para>
		/// <para>
		/// [GLES3.2] Gl.Get: data returns a single value, the maximum number of atomic counters available to tessellation 
		/// evaluation shaders.
		/// </para>
		/// </summary>
		[AliasOf("GL_MAX_TESS_EVALUATION_ATOMIC_COUNTERS_EXT")]
		[AliasOf("GL_MAX_TESS_EVALUATION_ATOMIC_COUNTERS_OES")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_atomic_counters", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_tessellation_shader", Api = "gles2")]
		[RequiredByFeature("GL_OES_tessellation_shader", Api = "gles2")]
		public const int MAX_TESS_EVALUATION_ATOMIC_COUNTERS = 0x92D4;

		/// <summary>
		/// <para>
		/// [GL4] Gl.Get: data returns a single value, the maximum number of atomic counters available to geometry shaders.
		/// </para>
		/// <para>
		/// [GLES3.2] Gl.Get: data returns a single value, the maximum number of atomic counters available to geometry shaders.
		/// </para>
		/// </summary>
		[AliasOf("GL_MAX_GEOMETRY_ATOMIC_COUNTERS_EXT")]
		[AliasOf("GL_MAX_GEOMETRY_ATOMIC_COUNTERS_OES")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_atomic_counters", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_geometry_shader", Api = "gles2")]
		[RequiredByFeature("GL_OES_geometry_shader", Api = "gles2")]
		public const int MAX_GEOMETRY_ATOMIC_COUNTERS = 0x92D5;

		/// <summary>
		/// <para>
		/// [GL4] Gl.Get: data returns a single value, the maximum number of atomic counters available to fragment shaders.
		/// </para>
		/// <para>
		/// [GLES3.2] Gl.Get: data returns a single value, the maximum number of atomic counters available to fragment shaders. In 
		/// GL ES 3.1, the minimum value is 0. in GL ES 3.2, the minimum value is 8.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_atomic_counters", Api = "gl|glcore")]
		public const int MAX_FRAGMENT_ATOMIC_COUNTERS = 0x92D6;

		/// <summary>
		/// <para>
		/// [GL4] Gl.Get: data returns a single value, the maximum number of atomic counters available to all active shaders.
		/// </para>
		/// <para>
		/// [GLES3.2] Gl.Get: data returns a single value, the maximum number of atomic counters available to all active shaders.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_atomic_counters", Api = "gl|glcore")]
		public const int MAX_COMBINED_ATOMIC_COUNTERS = 0x92D7;

		/// <summary>
		/// [GL] Value of GL_MAX_ATOMIC_COUNTER_BUFFER_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_atomic_counters", Api = "gl|glcore")]
		public const int MAX_ATOMIC_COUNTER_BUFFER_SIZE = 0x92D8;

		/// <summary>
		/// [GLES3.2] Gl.Get: data returns one value, the maximum number of atomic counter buffer binding points. The value must be 
		/// at least 1. See Gl.BindBuffer, Gl.BindBufferBase, and Gl.BindBufferRange.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_atomic_counters", Api = "gl|glcore")]
		public const int MAX_ATOMIC_COUNTER_BUFFER_BINDINGS = 0x92DC;

		/// <summary>
		/// <para>
		/// [GL4] Gl.GetProgram: params returns the number of active attribute atomic counter buffers used by program.
		/// </para>
		/// <para>
		/// [GLES3.2] Gl.GetProgram: params returns the number of active attribute atomic counter buffers used by program.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_atomic_counters", Api = "gl|glcore")]
		public const int ACTIVE_ATOMIC_COUNTER_BUFFERS = 0x92D9;

		/// <summary>
		/// [GL] Value of GL_UNIFORM_ATOMIC_COUNTER_BUFFER_INDEX symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_atomic_counters", Api = "gl|glcore")]
		public const int UNIFORM_ATOMIC_COUNTER_BUFFER_INDEX = 0x92DA;

		/// <summary>
		/// [GL] Value of GL_UNSIGNED_INT_ATOMIC_COUNTER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_atomic_counters", Api = "gl|glcore")]
		public const int UNSIGNED_INT_ATOMIC_COUNTER = 0x92DB;

		/// <summary>
		/// [GL] Value of GL_VERTEX_ATTRIB_ARRAY_BARRIER_BIT symbol.
		/// </summary>
		[AliasOf("GL_VERTEX_ATTRIB_ARRAY_BARRIER_BIT_EXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		[Log(BitmaskName = "GL")]
		public const uint VERTEX_ATTRIB_ARRAY_BARRIER_BIT = 0x00000001;

		/// <summary>
		/// [GL] Value of GL_ELEMENT_ARRAY_BARRIER_BIT symbol.
		/// </summary>
		[AliasOf("GL_ELEMENT_ARRAY_BARRIER_BIT_EXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		[Log(BitmaskName = "GL")]
		public const uint ELEMENT_ARRAY_BARRIER_BIT = 0x00000002;

		/// <summary>
		/// [GL] Value of GL_UNIFORM_BARRIER_BIT symbol.
		/// </summary>
		[AliasOf("GL_UNIFORM_BARRIER_BIT_EXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		[Log(BitmaskName = "GL")]
		public const uint UNIFORM_BARRIER_BIT = 0x00000004;

		/// <summary>
		/// [GL] Value of GL_TEXTURE_FETCH_BARRIER_BIT symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE_FETCH_BARRIER_BIT_EXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		[Log(BitmaskName = "GL")]
		public const uint TEXTURE_FETCH_BARRIER_BIT = 0x00000008;

		/// <summary>
		/// [GL] Value of GL_SHADER_IMAGE_ACCESS_BARRIER_BIT symbol.
		/// </summary>
		[AliasOf("GL_SHADER_IMAGE_ACCESS_BARRIER_BIT_EXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		[Log(BitmaskName = "GL")]
		public const uint SHADER_IMAGE_ACCESS_BARRIER_BIT = 0x00000020;

		/// <summary>
		/// [GL] Value of GL_COMMAND_BARRIER_BIT symbol.
		/// </summary>
		[AliasOf("GL_COMMAND_BARRIER_BIT_EXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		[Log(BitmaskName = "GL")]
		public const uint COMMAND_BARRIER_BIT = 0x00000040;

		/// <summary>
		/// [GL] Value of GL_PIXEL_BUFFER_BARRIER_BIT symbol.
		/// </summary>
		[AliasOf("GL_PIXEL_BUFFER_BARRIER_BIT_EXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		[Log(BitmaskName = "GL")]
		public const uint PIXEL_BUFFER_BARRIER_BIT = 0x00000080;

		/// <summary>
		/// [GL] Value of GL_TEXTURE_UPDATE_BARRIER_BIT symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE_UPDATE_BARRIER_BIT_EXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		[Log(BitmaskName = "GL")]
		public const uint TEXTURE_UPDATE_BARRIER_BIT = 0x00000100;

		/// <summary>
		/// [GL] Value of GL_BUFFER_UPDATE_BARRIER_BIT symbol.
		/// </summary>
		[AliasOf("GL_BUFFER_UPDATE_BARRIER_BIT_EXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		[Log(BitmaskName = "GL")]
		public const uint BUFFER_UPDATE_BARRIER_BIT = 0x00000200;

		/// <summary>
		/// [GL] Value of GL_FRAMEBUFFER_BARRIER_BIT symbol.
		/// </summary>
		[AliasOf("GL_FRAMEBUFFER_BARRIER_BIT_EXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		[Log(BitmaskName = "GL")]
		public const uint FRAMEBUFFER_BARRIER_BIT = 0x00000400;

		/// <summary>
		/// [GL] Value of GL_TRANSFORM_FEEDBACK_BARRIER_BIT symbol.
		/// </summary>
		[AliasOf("GL_TRANSFORM_FEEDBACK_BARRIER_BIT_EXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		[Log(BitmaskName = "GL")]
		public const uint TRANSFORM_FEEDBACK_BARRIER_BIT = 0x00000800;

		/// <summary>
		/// [GL] Value of GL_ATOMIC_COUNTER_BARRIER_BIT symbol.
		/// </summary>
		[AliasOf("GL_ATOMIC_COUNTER_BARRIER_BIT_EXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		[Log(BitmaskName = "GL")]
		public const uint ATOMIC_COUNTER_BARRIER_BIT = 0x00001000;

		/// <summary>
		/// [GL] Value of GL_ALL_BARRIER_BITS symbol.
		/// </summary>
		[AliasOf("GL_ALL_BARRIER_BITS_EXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		[Log(BitmaskName = "GL")]
		public const uint ALL_BARRIER_BITS = 0xFFFFFFFF;

		/// <summary>
		/// [GL] Value of GL_MAX_IMAGE_UNITS symbol.
		/// </summary>
		[AliasOf("GL_MAX_IMAGE_UNITS_EXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int MAX_IMAGE_UNITS = 0x8F38;

		/// <summary>
		/// [GL] Value of GL_MAX_COMBINED_IMAGE_UNITS_AND_FRAGMENT_OUTPUTS symbol.
		/// </summary>
		[AliasOf("GL_MAX_COMBINED_IMAGE_UNITS_AND_FRAGMENT_OUTPUTS_EXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_ARB_shader_storage_buffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int MAX_COMBINED_IMAGE_UNITS_AND_FRAGMENT_OUTPUTS = 0x8F39;

		/// <summary>
		/// [GL] Value of GL_IMAGE_BINDING_NAME symbol.
		/// </summary>
		[AliasOf("GL_IMAGE_BINDING_NAME_EXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int IMAGE_BINDING_NAME = 0x8F3A;

		/// <summary>
		/// [GL] Value of GL_IMAGE_BINDING_LEVEL symbol.
		/// </summary>
		[AliasOf("GL_IMAGE_BINDING_LEVEL_EXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int IMAGE_BINDING_LEVEL = 0x8F3B;

		/// <summary>
		/// [GLES3.2] Gl.Get: data returns one value, corresponding to whether the image bound to the indexed image unit is layered 
		/// or not.
		/// </summary>
		[AliasOf("GL_IMAGE_BINDING_LAYERED_EXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int IMAGE_BINDING_LAYERED = 0x8F3C;

		/// <summary>
		/// [GL] Value of GL_IMAGE_BINDING_LAYER symbol.
		/// </summary>
		[AliasOf("GL_IMAGE_BINDING_LAYER_EXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int IMAGE_BINDING_LAYER = 0x8F3D;

		/// <summary>
		/// [GL] Value of GL_IMAGE_BINDING_ACCESS symbol.
		/// </summary>
		[AliasOf("GL_IMAGE_BINDING_ACCESS_EXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int IMAGE_BINDING_ACCESS = 0x8F3E;

		/// <summary>
		/// [GL] Value of GL_IMAGE_1D symbol.
		/// </summary>
		[AliasOf("GL_IMAGE_1D_EXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int IMAGE_1D = 0x904C;

		/// <summary>
		/// [GL] Value of GL_IMAGE_2D symbol.
		/// </summary>
		[AliasOf("GL_IMAGE_2D_EXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int IMAGE_2D = 0x904D;

		/// <summary>
		/// [GL] Value of GL_IMAGE_3D symbol.
		/// </summary>
		[AliasOf("GL_IMAGE_3D_EXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int IMAGE_3D = 0x904E;

		/// <summary>
		/// [GL] Value of GL_IMAGE_2D_RECT symbol.
		/// </summary>
		[AliasOf("GL_IMAGE_2D_RECT_EXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int IMAGE_2D_RECT = 0x904F;

		/// <summary>
		/// [GL] Value of GL_IMAGE_CUBE symbol.
		/// </summary>
		[AliasOf("GL_IMAGE_CUBE_EXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int IMAGE_CUBE = 0x9050;

		/// <summary>
		/// [GL] Value of GL_IMAGE_BUFFER symbol.
		/// </summary>
		[AliasOf("GL_IMAGE_BUFFER_EXT")]
		[AliasOf("GL_IMAGE_BUFFER_OES")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		[RequiredByFeature("GL_EXT_texture_buffer", Api = "gles2")]
		[RequiredByFeature("GL_OES_texture_buffer", Api = "gles2")]
		public const int IMAGE_BUFFER = 0x9051;

		/// <summary>
		/// [GL] Value of GL_IMAGE_1D_ARRAY symbol.
		/// </summary>
		[AliasOf("GL_IMAGE_1D_ARRAY_EXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int IMAGE_1D_ARRAY = 0x9052;

		/// <summary>
		/// [GL] Value of GL_IMAGE_2D_ARRAY symbol.
		/// </summary>
		[AliasOf("GL_IMAGE_2D_ARRAY_EXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int IMAGE_2D_ARRAY = 0x9053;

		/// <summary>
		/// [GL] Value of GL_IMAGE_CUBE_MAP_ARRAY symbol.
		/// </summary>
		[AliasOf("GL_IMAGE_CUBE_MAP_ARRAY_EXT")]
		[AliasOf("GL_IMAGE_CUBE_MAP_ARRAY_OES")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		[RequiredByFeature("GL_EXT_texture_cube_map_array", Api = "gles2")]
		[RequiredByFeature("GL_OES_texture_cube_map_array", Api = "gles2")]
		public const int IMAGE_CUBE_MAP_ARRAY = 0x9054;

		/// <summary>
		/// [GL] Value of GL_IMAGE_2D_MULTISAMPLE symbol.
		/// </summary>
		[AliasOf("GL_IMAGE_2D_MULTISAMPLE_EXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int IMAGE_2D_MULTISAMPLE = 0x9055;

		/// <summary>
		/// [GL] Value of GL_IMAGE_2D_MULTISAMPLE_ARRAY symbol.
		/// </summary>
		[AliasOf("GL_IMAGE_2D_MULTISAMPLE_ARRAY_EXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int IMAGE_2D_MULTISAMPLE_ARRAY = 0x9056;

		/// <summary>
		/// [GL] Value of GL_INT_IMAGE_1D symbol.
		/// </summary>
		[AliasOf("GL_INT_IMAGE_1D_EXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int INT_IMAGE_1D = 0x9057;

		/// <summary>
		/// [GL] Value of GL_INT_IMAGE_2D symbol.
		/// </summary>
		[AliasOf("GL_INT_IMAGE_2D_EXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int INT_IMAGE_2D = 0x9058;

		/// <summary>
		/// [GL] Value of GL_INT_IMAGE_3D symbol.
		/// </summary>
		[AliasOf("GL_INT_IMAGE_3D_EXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int INT_IMAGE_3D = 0x9059;

		/// <summary>
		/// [GL] Value of GL_INT_IMAGE_2D_RECT symbol.
		/// </summary>
		[AliasOf("GL_INT_IMAGE_2D_RECT_EXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int INT_IMAGE_2D_RECT = 0x905A;

		/// <summary>
		/// [GL] Value of GL_INT_IMAGE_CUBE symbol.
		/// </summary>
		[AliasOf("GL_INT_IMAGE_CUBE_EXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int INT_IMAGE_CUBE = 0x905B;

		/// <summary>
		/// [GL] Value of GL_INT_IMAGE_BUFFER symbol.
		/// </summary>
		[AliasOf("GL_INT_IMAGE_BUFFER_EXT")]
		[AliasOf("GL_INT_IMAGE_BUFFER_OES")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		[RequiredByFeature("GL_EXT_texture_buffer", Api = "gles2")]
		[RequiredByFeature("GL_OES_texture_buffer", Api = "gles2")]
		public const int INT_IMAGE_BUFFER = 0x905C;

		/// <summary>
		/// [GL] Value of GL_INT_IMAGE_1D_ARRAY symbol.
		/// </summary>
		[AliasOf("GL_INT_IMAGE_1D_ARRAY_EXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int INT_IMAGE_1D_ARRAY = 0x905D;

		/// <summary>
		/// [GL] Value of GL_INT_IMAGE_2D_ARRAY symbol.
		/// </summary>
		[AliasOf("GL_INT_IMAGE_2D_ARRAY_EXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int INT_IMAGE_2D_ARRAY = 0x905E;

		/// <summary>
		/// [GL] Value of GL_INT_IMAGE_CUBE_MAP_ARRAY symbol.
		/// </summary>
		[AliasOf("GL_INT_IMAGE_CUBE_MAP_ARRAY_EXT")]
		[AliasOf("GL_INT_IMAGE_CUBE_MAP_ARRAY_OES")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		[RequiredByFeature("GL_EXT_texture_cube_map_array", Api = "gles2")]
		[RequiredByFeature("GL_OES_texture_cube_map_array", Api = "gles2")]
		public const int INT_IMAGE_CUBE_MAP_ARRAY = 0x905F;

		/// <summary>
		/// [GL] Value of GL_INT_IMAGE_2D_MULTISAMPLE symbol.
		/// </summary>
		[AliasOf("GL_INT_IMAGE_2D_MULTISAMPLE_EXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int INT_IMAGE_2D_MULTISAMPLE = 0x9060;

		/// <summary>
		/// [GL] Value of GL_INT_IMAGE_2D_MULTISAMPLE_ARRAY symbol.
		/// </summary>
		[AliasOf("GL_INT_IMAGE_2D_MULTISAMPLE_ARRAY_EXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int INT_IMAGE_2D_MULTISAMPLE_ARRAY = 0x9061;

		/// <summary>
		/// [GL] Value of GL_UNSIGNED_INT_IMAGE_1D symbol.
		/// </summary>
		[AliasOf("GL_UNSIGNED_INT_IMAGE_1D_EXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int UNSIGNED_INT_IMAGE_1D = 0x9062;

		/// <summary>
		/// [GL] Value of GL_UNSIGNED_INT_IMAGE_2D symbol.
		/// </summary>
		[AliasOf("GL_UNSIGNED_INT_IMAGE_2D_EXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int UNSIGNED_INT_IMAGE_2D = 0x9063;

		/// <summary>
		/// [GL] Value of GL_UNSIGNED_INT_IMAGE_3D symbol.
		/// </summary>
		[AliasOf("GL_UNSIGNED_INT_IMAGE_3D_EXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int UNSIGNED_INT_IMAGE_3D = 0x9064;

		/// <summary>
		/// [GL] Value of GL_UNSIGNED_INT_IMAGE_2D_RECT symbol.
		/// </summary>
		[AliasOf("GL_UNSIGNED_INT_IMAGE_2D_RECT_EXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int UNSIGNED_INT_IMAGE_2D_RECT = 0x9065;

		/// <summary>
		/// [GL] Value of GL_UNSIGNED_INT_IMAGE_CUBE symbol.
		/// </summary>
		[AliasOf("GL_UNSIGNED_INT_IMAGE_CUBE_EXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int UNSIGNED_INT_IMAGE_CUBE = 0x9066;

		/// <summary>
		/// [GL] Value of GL_UNSIGNED_INT_IMAGE_BUFFER symbol.
		/// </summary>
		[AliasOf("GL_UNSIGNED_INT_IMAGE_BUFFER_EXT")]
		[AliasOf("GL_UNSIGNED_INT_IMAGE_BUFFER_OES")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		[RequiredByFeature("GL_EXT_texture_buffer", Api = "gles2")]
		[RequiredByFeature("GL_OES_texture_buffer", Api = "gles2")]
		public const int UNSIGNED_INT_IMAGE_BUFFER = 0x9067;

		/// <summary>
		/// [GL] Value of GL_UNSIGNED_INT_IMAGE_1D_ARRAY symbol.
		/// </summary>
		[AliasOf("GL_UNSIGNED_INT_IMAGE_1D_ARRAY_EXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int UNSIGNED_INT_IMAGE_1D_ARRAY = 0x9068;

		/// <summary>
		/// [GL] Value of GL_UNSIGNED_INT_IMAGE_2D_ARRAY symbol.
		/// </summary>
		[AliasOf("GL_UNSIGNED_INT_IMAGE_2D_ARRAY_EXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int UNSIGNED_INT_IMAGE_2D_ARRAY = 0x9069;

		/// <summary>
		/// [GL] Value of GL_UNSIGNED_INT_IMAGE_CUBE_MAP_ARRAY symbol.
		/// </summary>
		[AliasOf("GL_UNSIGNED_INT_IMAGE_CUBE_MAP_ARRAY_EXT")]
		[AliasOf("GL_UNSIGNED_INT_IMAGE_CUBE_MAP_ARRAY_OES")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		[RequiredByFeature("GL_EXT_texture_cube_map_array", Api = "gles2")]
		[RequiredByFeature("GL_OES_texture_cube_map_array", Api = "gles2")]
		public const int UNSIGNED_INT_IMAGE_CUBE_MAP_ARRAY = 0x906A;

		/// <summary>
		/// [GL] Value of GL_UNSIGNED_INT_IMAGE_2D_MULTISAMPLE symbol.
		/// </summary>
		[AliasOf("GL_UNSIGNED_INT_IMAGE_2D_MULTISAMPLE_EXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int UNSIGNED_INT_IMAGE_2D_MULTISAMPLE = 0x906B;

		/// <summary>
		/// [GL] Value of GL_UNSIGNED_INT_IMAGE_2D_MULTISAMPLE_ARRAY symbol.
		/// </summary>
		[AliasOf("GL_UNSIGNED_INT_IMAGE_2D_MULTISAMPLE_ARRAY_EXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int UNSIGNED_INT_IMAGE_2D_MULTISAMPLE_ARRAY = 0x906C;

		/// <summary>
		/// [GL] Value of GL_MAX_IMAGE_SAMPLES symbol.
		/// </summary>
		[AliasOf("GL_MAX_IMAGE_SAMPLES_EXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int MAX_IMAGE_SAMPLES = 0x906D;

		/// <summary>
		/// [GL] Value of GL_IMAGE_BINDING_FORMAT symbol.
		/// </summary>
		[AliasOf("GL_IMAGE_BINDING_FORMAT_EXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int IMAGE_BINDING_FORMAT = 0x906E;

		/// <summary>
		/// <para>
		/// [GL4] Gl.GetTexParameter: Returns the matching criteria use for the texture when used as an image texture. Can return 
		/// Gl.IMAGE_FORMAT_COMPATIBILITY_BY_SIZE, Gl.IMAGE_FORMAT_COMPATIBILITY_BY_CLASS or Gl.NONE.
		/// </para>
		/// <para>
		/// [GLES3.2] Gl.GetTexParameter: Returns the single-valued image format compatibility matching criteria. This can be one of 
		/// Gl.IMAGE_FORMAT_COMPATIBILITY_BY_CLASS or Gl.IMAGE_FORMAT_COMPATIBILITY_BY_SIZE.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		public const int IMAGE_FORMAT_COMPATIBILITY_TYPE = 0x90C7;

		/// <summary>
		/// [GL] Value of GL_IMAGE_FORMAT_COMPATIBILITY_BY_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		public const int IMAGE_FORMAT_COMPATIBILITY_BY_SIZE = 0x90C8;

		/// <summary>
		/// [GL] Value of GL_IMAGE_FORMAT_COMPATIBILITY_BY_CLASS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		public const int IMAGE_FORMAT_COMPATIBILITY_BY_CLASS = 0x90C9;

		/// <summary>
		/// [GLES3.2] Gl.Get: data returns one value, the maximum supported number of image variables in vertex shaders.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		public const int MAX_VERTEX_IMAGE_UNIFORMS = 0x90CA;

		/// <summary>
		/// [GLES3.2] Gl.Get: data returns one value, the maximum supported number of image variables in tesselation control 
		/// shaders.
		/// </summary>
		[AliasOf("GL_MAX_TESS_CONTROL_IMAGE_UNIFORMS_EXT")]
		[AliasOf("GL_MAX_TESS_CONTROL_IMAGE_UNIFORMS_OES")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_tessellation_shader", Api = "gles2")]
		[RequiredByFeature("GL_OES_tessellation_shader", Api = "gles2")]
		public const int MAX_TESS_CONTROL_IMAGE_UNIFORMS = 0x90CB;

		/// <summary>
		/// [GLES3.2] Gl.Get: data returns one value, the maximum supported number of image variables in tesselation evaluation 
		/// shaders.
		/// </summary>
		[AliasOf("GL_MAX_TESS_EVALUATION_IMAGE_UNIFORMS_EXT")]
		[AliasOf("GL_MAX_TESS_EVALUATION_IMAGE_UNIFORMS_OES")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_tessellation_shader", Api = "gles2")]
		[RequiredByFeature("GL_OES_tessellation_shader", Api = "gles2")]
		public const int MAX_TESS_EVALUATION_IMAGE_UNIFORMS = 0x90CC;

		/// <summary>
		/// [GLES3.2] Gl.Get: data returns one value, the maximum supported number of image variables in geometry shaders.
		/// </summary>
		[AliasOf("GL_MAX_GEOMETRY_IMAGE_UNIFORMS_EXT")]
		[AliasOf("GL_MAX_GEOMETRY_IMAGE_UNIFORMS_OES")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_geometry_shader", Api = "gles2")]
		[RequiredByFeature("GL_OES_geometry_shader", Api = "gles2")]
		public const int MAX_GEOMETRY_IMAGE_UNIFORMS = 0x90CD;

		/// <summary>
		/// [GLES3.2] Gl.Get: data returns one value, the maximum supported number of image variables in fragment shaders. In GL ES 
		/// 3.1, the minimum value is 0. in GL ES 3.2, the minimum value is 4.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		public const int MAX_FRAGMENT_IMAGE_UNIFORMS = 0x90CE;

		/// <summary>
		/// [GL] Value of GL_MAX_COMBINED_IMAGE_UNIFORMS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		public const int MAX_COMBINED_IMAGE_UNIFORMS = 0x90CF;

		/// <summary>
		/// [GL] Value of GL_COMPRESSED_RGBA_BPTC_UNORM symbol.
		/// </summary>
		[AliasOf("GL_COMPRESSED_RGBA_BPTC_UNORM_ARB")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_texture_compression_bptc", Api = "gl|glcore")]
		public const int COMPRESSED_RGBA_BPTC_UNORM = 0x8E8C;

		/// <summary>
		/// [GL] Value of GL_COMPRESSED_SRGB_ALPHA_BPTC_UNORM symbol.
		/// </summary>
		[AliasOf("GL_COMPRESSED_SRGB_ALPHA_BPTC_UNORM_ARB")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_texture_compression_bptc", Api = "gl|glcore")]
		public const int COMPRESSED_SRGB_ALPHA_BPTC_UNORM = 0x8E8D;

		/// <summary>
		/// [GL] Value of GL_COMPRESSED_RGB_BPTC_SIGNED_FLOAT symbol.
		/// </summary>
		[AliasOf("GL_COMPRESSED_RGB_BPTC_SIGNED_FLOAT_ARB")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_texture_compression_bptc", Api = "gl|glcore")]
		public const int COMPRESSED_RGB_BPTC_SIGNED_FLOAT = 0x8E8E;

		/// <summary>
		/// [GL] Value of GL_COMPRESSED_RGB_BPTC_UNSIGNED_FLOAT symbol.
		/// </summary>
		[AliasOf("GL_COMPRESSED_RGB_BPTC_UNSIGNED_FLOAT_ARB")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_texture_compression_bptc", Api = "gl|glcore")]
		public const int COMPRESSED_RGB_BPTC_UNSIGNED_FLOAT = 0x8E8F;

		/// <summary>
		/// <para>
		/// [GL4] Gl.GetTexParameter: Returns non-zero if the texture has an immutable format. Textures become immutable if their 
		/// storage is specified with Gl.TexStorage1D, Gl.TexStorage2D or Gl.TexStorage3D. The initial value is Gl.FALSE.
		/// </para>
		/// <para>
		/// [GLES3.2] Gl.GetTexParameter: Returns a single-value boolean representing the immutability of the texture format and 
		/// size. initial value is Gl.FALSE. See Gl.TexStorage2D.
		/// </para>
		/// </summary>
		[AliasOf("GL_TEXTURE_IMMUTABLE_FORMAT_EXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_storage", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_texture_storage", Api = "gles1|gles2")]
		public const int TEXTURE_IMMUTABLE_FORMAT = 0x912F;

		/// <summary>
		/// Binding for glDrawArraysInstancedBaseInstance.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:PrimitiveType"/>.
		/// </param>
		/// <param name="first">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="primcount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="baseinstance">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[AliasOf("glDrawArraysInstancedBaseInstanceEXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_base_instance", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_base_instance", Api = "gles2")]
		public static void DrawArraysInstancedBaseInstance(PrimitiveType mode, Int32 first, Int32 count, Int32 primcount, UInt32 baseinstance)
		{
			Debug.Assert(Delegates.pglDrawArraysInstancedBaseInstance != null, "pglDrawArraysInstancedBaseInstance not implemented");
			Delegates.pglDrawArraysInstancedBaseInstance((Int32)mode, first, count, primcount, baseinstance);
			LogCommand("glDrawArraysInstancedBaseInstance", null, mode, first, count, primcount, baseinstance			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glDrawElementsInstancedBaseInstance.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:PrimitiveType"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="indices">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="primcount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="baseinstance">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[AliasOf("glDrawElementsInstancedBaseInstanceEXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_base_instance", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_base_instance", Api = "gles2")]
		public static void DrawElementsInstancedBaseInstance(PrimitiveType mode, Int32 count, Int32 type, IntPtr indices, Int32 primcount, UInt32 baseinstance)
		{
			Debug.Assert(Delegates.pglDrawElementsInstancedBaseInstance != null, "pglDrawElementsInstancedBaseInstance not implemented");
			Delegates.pglDrawElementsInstancedBaseInstance((Int32)mode, count, type, indices, primcount, baseinstance);
			LogCommand("glDrawElementsInstancedBaseInstance", null, mode, count, type, indices, primcount, baseinstance			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glDrawElementsInstancedBaseInstance.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:PrimitiveType"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="indices">
		/// A <see cref="T:Object"/>.
		/// </param>
		/// <param name="primcount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="baseinstance">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[AliasOf("glDrawElementsInstancedBaseInstanceEXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_base_instance", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_base_instance", Api = "gles2")]
		public static void DrawElementsInstancedBaseInstance(PrimitiveType mode, Int32 count, Int32 type, Object indices, Int32 primcount, UInt32 baseinstance)
		{
			GCHandle pin_indices = GCHandle.Alloc(indices, GCHandleType.Pinned);
			try {
				DrawElementsInstancedBaseInstance(mode, count, type, pin_indices.AddrOfPinnedObject(), primcount, baseinstance);
			} finally {
				pin_indices.Free();
			}
		}

		/// <summary>
		/// Binding for glDrawElementsInstancedBaseVertexBaseInstance.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:PrimitiveType"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="indices">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="primcount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="basevertex">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="baseinstance">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[AliasOf("glDrawElementsInstancedBaseVertexBaseInstanceEXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_base_instance", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_base_instance", Api = "gles2")]
		public static void DrawElementsInstancedBaseVertexBaseInstance(PrimitiveType mode, Int32 count, Int32 type, IntPtr indices, Int32 primcount, Int32 basevertex, UInt32 baseinstance)
		{
			Debug.Assert(Delegates.pglDrawElementsInstancedBaseVertexBaseInstance != null, "pglDrawElementsInstancedBaseVertexBaseInstance not implemented");
			Delegates.pglDrawElementsInstancedBaseVertexBaseInstance((Int32)mode, count, type, indices, primcount, basevertex, baseinstance);
			LogCommand("glDrawElementsInstancedBaseVertexBaseInstance", null, mode, count, type, indices, primcount, basevertex, baseinstance			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glDrawElementsInstancedBaseVertexBaseInstance.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:PrimitiveType"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="indices">
		/// A <see cref="T:Object"/>.
		/// </param>
		/// <param name="primcount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="basevertex">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="baseinstance">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[AliasOf("glDrawElementsInstancedBaseVertexBaseInstanceEXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_base_instance", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_base_instance", Api = "gles2")]
		public static void DrawElementsInstancedBaseVertexBaseInstance(PrimitiveType mode, Int32 count, Int32 type, Object indices, Int32 primcount, Int32 basevertex, UInt32 baseinstance)
		{
			GCHandle pin_indices = GCHandle.Alloc(indices, GCHandleType.Pinned);
			try {
				DrawElementsInstancedBaseVertexBaseInstance(mode, count, type, pin_indices.AddrOfPinnedObject(), primcount, basevertex, baseinstance);
			} finally {
				pin_indices.Free();
			}
		}

		/// <summary>
		/// retrieve information about implementation-dependent support for internal formats
		/// </summary>
		/// <param name="target">
		/// Indicates the usage of the internal format. <paramref name="target"/> must be Gl.TEXTURE_1D, Gl.TEXTURE_1D_ARRAY, 
		/// Gl.TEXTURE_2D, Gl.TEXTURE_2D_ARRAY, Gl.TEXTURE_3D, Gl.TEXTURE_CUBE_MAP, Gl.TEXTURE_CUBE_MAP_ARRAY, Gl.TEXTURE_RECTANGLE, 
		/// Gl.TEXTURE_BUFFER, Gl.RENDERBUFFER, Gl.TEXTURE_2D_MULTISAMPLE or Gl.TEXTURE_2D_MULTISAMPLE_ARRAY.
		/// </param>
		/// <param name="internalformat">
		/// Specifies the internal format about which to retrieve information.
		/// </param>
		/// <param name="pname">
		/// Specifies the type of information to query.
		/// </param>
		/// <param name="params">
		/// Specifies the address of a variable into which to write the retrieved information.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="bufSize"/> is negative.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not Gl.SAMPLES or Gl.NUM_SAMPLE_COUNTS.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="internalformat"/> is not color-, depth-, or stencil-renderable.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> is not one of Gl.TEXTURE_2D_MULTISAMPLE, 
		/// Gl.TEXTURE_2D_MULTISAMPLE_ARRAY or Gl.RENDERBUFFER.
		/// </exception>
		/// <seealso cref="Gl.Get"/>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_internalformat_query", Api = "gl|glcore")]
		public static void GetInternalformat(Int32 target, Int32 internalformat, Int32 pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetInternalformativ != null, "pglGetInternalformativ not implemented");
					Delegates.pglGetInternalformativ(target, internalformat, pname, (Int32)@params.Length, p_params);
					LogCommand("glGetInternalformativ", null, target, internalformat, pname, @params.Length, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// retrieve information about the set of active atomic counter buffers for a program
		/// </summary>
		/// <param name="program">
		/// The name of a program object from which to retrieve information.
		/// </param>
		/// <param name="bufferIndex">
		/// Specifies index of an active atomic counter buffer.
		/// </param>
		/// <param name="pname">
		/// Specifies which parameter of the atomic counter buffer to retrieve.
		/// </param>
		/// <param name="params">
		/// Specifies the address of a variable into which to write the retrieved information.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="program"/> is not the name of a program object for which glLinkProgram 
		/// has been called in the past.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="bufferIndex"/> is greater than or equal to the value of 
		/// Gl.ACTIVE_ATOMIC_COUNTER_BUFFERS for <paramref name="program"/>.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not one of the accepted tokens.
		/// </exception>
		/// <seealso cref="Gl.GetProgram"/>
		/// <seealso cref="Gl.GetActiveSubroutineUniform"/>
		/// <seealso cref="Gl.GetActiveSubroutineUniformName"/>
		/// <seealso cref="Gl.GetUniformLocation"/>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_atomic_counters", Api = "gl|glcore")]
		public static void GetActiveAtomicCounterBuffer(UInt32 program, UInt32 bufferIndex, Int32 pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetActiveAtomicCounterBufferiv != null, "pglGetActiveAtomicCounterBufferiv not implemented");
					Delegates.pglGetActiveAtomicCounterBufferiv(program, bufferIndex, pname, p_params);
					LogCommand("glGetActiveAtomicCounterBufferiv", null, program, bufferIndex, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// bind a level of a texture to an image unit
		/// </summary>
		/// <param name="unit">
		/// Specifies the index of the image unit to which to bind the texture
		/// </param>
		/// <param name="texture">
		/// Specifies the name of the texture to bind to the image unit.
		/// </param>
		/// <param name="level">
		/// Specifies the level of the texture that is to be bound.
		/// </param>
		/// <param name="layered">
		/// Specifies whether a layered texture binding is to be established.
		/// </param>
		/// <param name="layer">
		/// If <paramref name="layered"/> is Gl.FALSE, specifies the layer of <paramref name="texture"/> to be bound to the image 
		/// unit. Ignored otherwise.
		/// </param>
		/// <param name="access">
		/// Specifies a token indicating the type of access that will be performed on the image.
		/// </param>
		/// <param name="format">
		/// Specifies the format that the elements of the image will be treated as for the purposes of formatted stores.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="unit"/> greater than or equal to the value of Gl.MAX_IMAGE_UNITS.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="texture"/> is not the name of an existing texture object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="level"/> or <paramref name="layer"/> is less than zero.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="access"/> or <paramref name="format"/> is not one of the supported 
		/// tokens.
		/// </exception>
		/// <seealso cref="Gl.GenTextures"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexStorage1D"/>
		/// <seealso cref="Gl.TexStorage2D"/>
		/// <seealso cref="Gl.TexStorage3D"/>
		/// <seealso cref="Gl.BindTexture"/>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		public static void BindImageTexture(UInt32 unit, UInt32 texture, Int32 level, bool layered, Int32 layer, Int32 access, Int32 format)
		{
			Debug.Assert(Delegates.pglBindImageTexture != null, "pglBindImageTexture not implemented");
			Delegates.pglBindImageTexture(unit, texture, level, layered, layer, access, format);
			LogCommand("glBindImageTexture", null, unit, texture, level, layered, layer, access, format			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// defines a barrier ordering memory transactions
		/// </summary>
		/// <param name="barriers">
		/// Specifies the barriers to insert.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="barriers"/> is not the special value Gl.ALL_BARRIER_BITS, and has any 
		/// bits set other than those described above for Gl.MemoryBarrier or Gl.MemoryBarrierByRegion respectively.
		/// </exception>
		/// <seealso cref="Gl.BindImageTexture"/>
		/// <seealso cref="Gl.BufferData"/>
		/// <seealso cref="Gl.MapBuffer"/>
		/// <seealso cref="Gl.MapBufferRange"/>
		/// <seealso cref="Gl.FlushMappedBufferRange"/>
		/// <seealso cref="Gl.moryBarrier"/>
		[AliasOf("glMemoryBarrierEXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public static void MemoryBarrier(UInt32 barriers)
		{
			Debug.Assert(Delegates.pglMemoryBarrier != null, "pglMemoryBarrier not implemented");
			Delegates.pglMemoryBarrier(barriers);
			LogCommand("glMemoryBarrier", null, barriers			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTexStorage1D.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="levels">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[AliasOf("glTexStorage1DEXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_texture_storage", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_texture_storage", Api = "gles1|gles2")]
		public static void TexStorage1D(Int32 target, Int32 levels, Int32 internalformat, Int32 width)
		{
			Debug.Assert(Delegates.pglTexStorage1D != null, "pglTexStorage1D not implemented");
			Delegates.pglTexStorage1D(target, levels, internalformat, width);
			LogCommand("glTexStorage1D", null, target, levels, internalformat, width			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTexStorage2D.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="levels">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[AliasOf("glTexStorage2DEXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_storage", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_texture_storage", Api = "gles1|gles2")]
		public static void TexStorage2D(Int32 target, Int32 levels, Int32 internalformat, Int32 width, Int32 height)
		{
			Debug.Assert(Delegates.pglTexStorage2D != null, "pglTexStorage2D not implemented");
			Delegates.pglTexStorage2D(target, levels, internalformat, width, height);
			LogCommand("glTexStorage2D", null, target, levels, internalformat, width, height			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTexStorage3D.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="levels">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="depth">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[AliasOf("glTexStorage3DEXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_storage", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_texture_storage", Api = "gles1|gles2")]
		public static void TexStorage3D(Int32 target, Int32 levels, Int32 internalformat, Int32 width, Int32 height, Int32 depth)
		{
			Debug.Assert(Delegates.pglTexStorage3D != null, "pglTexStorage3D not implemented");
			Delegates.pglTexStorage3D(target, levels, internalformat, width, height, depth);
			LogCommand("glTexStorage3D", null, target, levels, internalformat, width, height, depth			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// render multiple instances of primitives using a count derived from a transform feedback object
		/// </summary>
		/// <param name="mode">
		/// Specifies what kind of primitives to render. Symbolic constants Gl.POINTS, Gl.LINE_STRIP, Gl.LINE_LOOP, Gl.LINES, 
		/// Gl.LINE_STRIP_ADJACENCY, Gl.LINES_ADJACENCY, Gl.TRIANGLE_STRIP, Gl.TRIANGLE_FAN, Gl.TRIANGLES, 
		/// Gl.TRIANGLE_STRIP_ADJACENCY, Gl.TRIANGLES_ADJACENCY, and Gl.PATCHES are accepted.
		/// </param>
		/// <param name="id">
		/// Specifies the name of a transform feedback object from which to retrieve a primitive count.
		/// </param>
		/// <param name="primcount">
		/// Specifies the number of instances of the geometry to render.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="mode"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="id"/> is not the name of a transform feedback object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="stream"/> is greater than or equal to the value of 
		/// Gl.MAX_VERTEX_STREAMS.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to an enabled array and the buffer object's 
		/// data store is currently mapped.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a geometry shader is active and <paramref name="mode"/> is incompatible with the 
		/// input primitive type of the geometry shader in the currently installed program object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="mode"/> is Gl.PATCHES and no tessellation control shader is active.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.EndTransformFeedback has never been called while the transform feedback object 
		/// named by <paramref name="id"/> was bound.
		/// </exception>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawArraysInstanced"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawTransformFeedback"/>
		/// <seealso cref="Gl.DrawTransformFeedbackStreamInstanced"/>
		[AliasOf("glDrawTransformFeedbackInstancedEXT")]
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_transform_feedback_instanced", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_draw_transform_feedback", Api = "gles2")]
		public static void DrawTransformFeedbackInstanced(PrimitiveType mode, UInt32 id, Int32 primcount)
		{
			Debug.Assert(Delegates.pglDrawTransformFeedbackInstanced != null, "pglDrawTransformFeedbackInstanced not implemented");
			Delegates.pglDrawTransformFeedbackInstanced((Int32)mode, id, primcount);
			LogCommand("glDrawTransformFeedbackInstanced", null, mode, id, primcount			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// render multiple instances of primitives using a count derived from a specifed stream of a transform feedback object
		/// </summary>
		/// <param name="mode">
		/// Specifies what kind of primitives to render. Symbolic constants Gl.POINTS, Gl.LINE_STRIP, Gl.LINE_LOOP, Gl.LINES, 
		/// Gl.LINE_STRIP_ADJACENCY, Gl.LINES_ADJACENCY, Gl.TRIANGLE_STRIP, Gl.TRIANGLE_FAN, Gl.TRIANGLES, 
		/// Gl.TRIANGLE_STRIP_ADJACENCY, Gl.TRIANGLES_ADJACENCY, and Gl.PATCHES are accepted.
		/// </param>
		/// <param name="id">
		/// Specifies the name of a transform feedback object from which to retrieve a primitive count.
		/// </param>
		/// <param name="stream">
		/// Specifies the index of the transform feedback stream from which to retrieve a primitive count.
		/// </param>
		/// <param name="primcount">
		/// Specifies the number of instances of the geometry to render.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="mode"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="id"/> is not the name of a transform feedback object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="stream"/> is greater than or equal to the value of 
		/// Gl.MAX_VERTEX_STREAMS.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to an enabled array and the buffer object's 
		/// data store is currently mapped.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a geometry shader is active and <paramref name="mode"/> is incompatible with the 
		/// input primitive type of the geometry shader in the currently installed program object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="mode"/> is Gl.PATCHES and no tessellation control shader is active.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.EndTransformFeedback has never been called while the transform feedback object 
		/// named by <paramref name="id"/> was bound.
		/// </exception>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawArraysInstanced"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawTransformFeedback"/>
		/// <seealso cref="Gl.DrawTransformFeedbackStream"/>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_transform_feedback_instanced", Api = "gl|glcore")]
		public static void DrawTransformFeedbackStreamInstanced(PrimitiveType mode, UInt32 id, UInt32 stream, Int32 primcount)
		{
			Debug.Assert(Delegates.pglDrawTransformFeedbackStreamInstanced != null, "pglDrawTransformFeedbackStreamInstanced not implemented");
			Delegates.pglDrawTransformFeedbackStreamInstanced((Int32)mode, id, stream, primcount);
			LogCommand("glDrawTransformFeedbackStreamInstanced", null, mode, id, stream, primcount			);
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glDrawArraysInstancedBaseInstance", ExactSpelling = true)]
			internal extern static void glDrawArraysInstancedBaseInstance(Int32 mode, Int32 first, Int32 count, Int32 instancecount, UInt32 baseinstance);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glDrawElementsInstancedBaseInstance", ExactSpelling = true)]
			internal extern static unsafe void glDrawElementsInstancedBaseInstance(Int32 mode, Int32 count, Int32 type, IntPtr indices, Int32 instancecount, UInt32 baseinstance);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glDrawElementsInstancedBaseVertexBaseInstance", ExactSpelling = true)]
			internal extern static unsafe void glDrawElementsInstancedBaseVertexBaseInstance(Int32 mode, Int32 count, Int32 type, IntPtr indices, Int32 instancecount, Int32 basevertex, UInt32 baseinstance);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetInternalformativ", ExactSpelling = true)]
			internal extern static unsafe void glGetInternalformativ(Int32 target, Int32 internalformat, Int32 pname, Int32 bufSize, Int32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetActiveAtomicCounterBufferiv", ExactSpelling = true)]
			internal extern static unsafe void glGetActiveAtomicCounterBufferiv(UInt32 program, UInt32 bufferIndex, Int32 pname, Int32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glBindImageTexture", ExactSpelling = true)]
			internal extern static void glBindImageTexture(UInt32 unit, UInt32 texture, Int32 level, bool layered, Int32 layer, Int32 access, Int32 format);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMemoryBarrier", ExactSpelling = true)]
			internal extern static void glMemoryBarrier(UInt32 barriers);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexStorage1D", ExactSpelling = true)]
			internal extern static void glTexStorage1D(Int32 target, Int32 levels, Int32 internalformat, Int32 width);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexStorage2D", ExactSpelling = true)]
			internal extern static void glTexStorage2D(Int32 target, Int32 levels, Int32 internalformat, Int32 width, Int32 height);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexStorage3D", ExactSpelling = true)]
			internal extern static void glTexStorage3D(Int32 target, Int32 levels, Int32 internalformat, Int32 width, Int32 height, Int32 depth);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glDrawTransformFeedbackInstanced", ExactSpelling = true)]
			internal extern static void glDrawTransformFeedbackInstanced(Int32 mode, UInt32 id, Int32 instancecount);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glDrawTransformFeedbackStreamInstanced", ExactSpelling = true)]
			internal extern static void glDrawTransformFeedbackStreamInstanced(Int32 mode, UInt32 id, UInt32 stream, Int32 instancecount);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_VERSION_4_2")]
			[RequiredByFeature("GL_ARB_base_instance", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_base_instance", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glDrawArraysInstancedBaseInstance(Int32 mode, Int32 first, Int32 count, Int32 instancecount, UInt32 baseinstance);

			[AliasOf("glDrawArraysInstancedBaseInstance")]
			[AliasOf("glDrawArraysInstancedBaseInstanceEXT")]
			[ThreadStatic]
			internal static glDrawArraysInstancedBaseInstance pglDrawArraysInstancedBaseInstance;

			[RequiredByFeature("GL_VERSION_4_2")]
			[RequiredByFeature("GL_ARB_base_instance", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_base_instance", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glDrawElementsInstancedBaseInstance(Int32 mode, Int32 count, Int32 type, IntPtr indices, Int32 instancecount, UInt32 baseinstance);

			[AliasOf("glDrawElementsInstancedBaseInstance")]
			[AliasOf("glDrawElementsInstancedBaseInstanceEXT")]
			[ThreadStatic]
			internal static glDrawElementsInstancedBaseInstance pglDrawElementsInstancedBaseInstance;

			[RequiredByFeature("GL_VERSION_4_2")]
			[RequiredByFeature("GL_ARB_base_instance", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_base_instance", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glDrawElementsInstancedBaseVertexBaseInstance(Int32 mode, Int32 count, Int32 type, IntPtr indices, Int32 instancecount, Int32 basevertex, UInt32 baseinstance);

			[AliasOf("glDrawElementsInstancedBaseVertexBaseInstance")]
			[AliasOf("glDrawElementsInstancedBaseVertexBaseInstanceEXT")]
			[ThreadStatic]
			internal static glDrawElementsInstancedBaseVertexBaseInstance pglDrawElementsInstancedBaseVertexBaseInstance;

			[RequiredByFeature("GL_VERSION_4_2")]
			[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
			[RequiredByFeature("GL_ARB_internalformat_query", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetInternalformativ(Int32 target, Int32 internalformat, Int32 pname, Int32 bufSize, Int32* @params);

			[ThreadStatic]
			internal static glGetInternalformativ pglGetInternalformativ;

			[RequiredByFeature("GL_VERSION_4_2")]
			[RequiredByFeature("GL_ARB_shader_atomic_counters", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetActiveAtomicCounterBufferiv(UInt32 program, UInt32 bufferIndex, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetActiveAtomicCounterBufferiv pglGetActiveAtomicCounterBufferiv;

			[RequiredByFeature("GL_VERSION_4_2")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBindImageTexture(UInt32 unit, UInt32 texture, Int32 level, bool layered, Int32 layer, Int32 access, Int32 format);

			[ThreadStatic]
			internal static glBindImageTexture pglBindImageTexture;

			[RequiredByFeature("GL_VERSION_4_2")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_shader_image_load_store")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMemoryBarrier(UInt32 barriers);

			[AliasOf("glMemoryBarrier")]
			[AliasOf("glMemoryBarrierEXT")]
			[ThreadStatic]
			internal static glMemoryBarrier pglMemoryBarrier;

			[RequiredByFeature("GL_VERSION_4_2")]
			[RequiredByFeature("GL_ARB_texture_storage", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_texture_storage", Api = "gles1|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexStorage1D(Int32 target, Int32 levels, Int32 internalformat, Int32 width);

			[AliasOf("glTexStorage1D")]
			[AliasOf("glTexStorage1DEXT")]
			[ThreadStatic]
			internal static glTexStorage1D pglTexStorage1D;

			[RequiredByFeature("GL_VERSION_4_2")]
			[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
			[RequiredByFeature("GL_ARB_texture_storage", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_texture_storage", Api = "gles1|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexStorage2D(Int32 target, Int32 levels, Int32 internalformat, Int32 width, Int32 height);

			[AliasOf("glTexStorage2D")]
			[AliasOf("glTexStorage2DEXT")]
			[ThreadStatic]
			internal static glTexStorage2D pglTexStorage2D;

			[RequiredByFeature("GL_VERSION_4_2")]
			[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
			[RequiredByFeature("GL_ARB_texture_storage", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_texture_storage", Api = "gles1|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexStorage3D(Int32 target, Int32 levels, Int32 internalformat, Int32 width, Int32 height, Int32 depth);

			[AliasOf("glTexStorage3D")]
			[AliasOf("glTexStorage3DEXT")]
			[ThreadStatic]
			internal static glTexStorage3D pglTexStorage3D;

			[RequiredByFeature("GL_VERSION_4_2")]
			[RequiredByFeature("GL_ARB_transform_feedback_instanced", Api = "gl|glcore")]
			[RequiredByFeature("GL_EXT_draw_transform_feedback", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glDrawTransformFeedbackInstanced(Int32 mode, UInt32 id, Int32 instancecount);

			[AliasOf("glDrawTransformFeedbackInstanced")]
			[AliasOf("glDrawTransformFeedbackInstancedEXT")]
			[ThreadStatic]
			internal static glDrawTransformFeedbackInstanced pglDrawTransformFeedbackInstanced;

			[RequiredByFeature("GL_VERSION_4_2")]
			[RequiredByFeature("GL_ARB_transform_feedback_instanced", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glDrawTransformFeedbackStreamInstanced(Int32 mode, UInt32 id, UInt32 stream, Int32 instancecount);

			[ThreadStatic]
			internal static glDrawTransformFeedbackStreamInstanced pglDrawTransformFeedbackStreamInstanced;

		}
	}

}
