using System;

namespace Maple2.Trigger._61000008_me {
    public static class _g05p00_500 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {110, 111, 112, 113, 114, 115}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetMesh(arg1: new int[] {120, 121, 122, 123, 124, 125}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetMesh(arg1: new int[] {130, 131, 132, 133, 134, 135}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetMesh(arg1: new int[] {140, 141, 142, 143, 144, 145}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetMesh(arg1: new int[] {210, 211, 212, 213, 214, 215}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetMesh(arg1: new int[] {220, 221, 222, 223, 224, 225}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetMesh(arg1: new int[] {230, 231, 232, 233, 234, 235}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetMesh(arg1: new int[] {240, 241, 242, 243, 244, 245}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetMesh(arg1: new int[] {310, 311, 312, 313, 314, 315}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetMesh(arg1: new int[] {320, 321, 322, 323, 324, 325}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetMesh(arg1: new int[] {330, 331, 332, 333, 334, 335}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetMesh(arg1: new int[] {340, 341, 342, 343, 344, 345}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetMesh(arg1: new int[] {410, 411, 412, 413, 414, 415}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetMesh(arg1: new int[] {420, 421, 422, 423, 424, 425}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetMesh(arg1: new int[] {430, 431, 432, 433, 434, 435}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetMesh(arg1: new int[] {440, 441, 442, 443, 444, 445}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
            }

            public override void Execute() {
                if (context.UserValue(key: "G05P01Set", value: 1)) {
                    context.State = new StateNumberOnP01(context);
                    return;
                }

                if (context.UserValue(key: "G05P02Set", value: 1)) {
                    context.State = new StateNumberOnP02(context);
                    return;
                }

                if (context.UserValue(key: "G05P03Set", value: 1)) {
                    context.State = new StateNumberOnP03(context);
                    return;
                }

                if (context.UserValue(key: "G05P04Set", value: 1)) {
                    context.State = new StateNumberOnP04(context);
                    return;
                }

                if (context.UserValue(key: "G05P05Set", value: 1)) {
                    context.State = new StateNumberOnP05(context);
                    return;
                }

                if (context.UserValue(key: "G05P06Set", value: 1)) {
                    context.State = new StateNumberOnP06(context);
                    return;
                }

                if (context.UserValue(key: "G05P07Set", value: 1)) {
                    context.State = new StateNumberOnP07(context);
                    return;
                }

                if (context.UserValue(key: "G05P08Set", value: 1)) {
                    context.State = new StateNumberOnP08(context);
                    return;
                }

                if (context.UserValue(key: "G05P09Set", value: 1)) {
                    context.State = new StateNumberOnP09(context);
                    return;
                }

                if (context.UserValue(key: "G05P10Set", value: 1)) {
                    context.State = new StateNumberOnP10(context);
                    return;
                }

                if (context.UserValue(key: "G05P11Set", value: 1)) {
                    context.State = new StateNumberOnP11(context);
                    return;
                }

                if (context.UserValue(key: "G05P12Set", value: 1)) {
                    context.State = new StateNumberOnP12(context);
                    return;
                }

                if (context.UserValue(key: "G05P13Set", value: 1)) {
                    context.State = new StateNumberOnP13(context);
                    return;
                }

                if (context.UserValue(key: "G05P14Set", value: 1)) {
                    context.State = new StateNumberOnP14(context);
                    return;
                }

                if (context.UserValue(key: "G05P15Set", value: 1)) {
                    context.State = new StateNumberOnP15(context);
                    return;
                }

                if (context.UserValue(key: "G05P16Set", value: 1)) {
                    context.State = new StateNumberOnP16(context);
                    return;
                }

                if (context.UserValue(key: "G05P17Set", value: 1)) {
                    context.State = new StateNumberOnP17(context);
                    return;
                }

                if (context.UserValue(key: "G05P18Set", value: 1)) {
                    context.State = new StateNumberOnP18(context);
                    return;
                }

                if (context.UserValue(key: "G05P19Set", value: 1)) {
                    context.State = new StateNumberOnP19(context);
                    return;
                }

                if (context.UserValue(key: "G05P20Set", value: 1)) {
                    context.State = new StateNumberOnP20(context);
                    return;
                }

                if (context.UserValue(key: "G05P21Set", value: 1)) {
                    context.State = new StateNumberOnP21(context);
                    return;
                }

                if (context.UserValue(key: "G05P22Set", value: 1)) {
                    context.State = new StateNumberOnP22(context);
                    return;
                }

                if (context.UserValue(key: "G05P23Set", value: 1)) {
                    context.State = new StateNumberOnP23(context);
                    return;
                }

                if (context.UserValue(key: "G05P24Set", value: 1)) {
                    context.State = new StateNumberOnP24(context);
                    return;
                }

                if (context.UserValue(key: "G05P25Set", value: 1)) {
                    context.State = new StateNumberOnP25(context);
                    return;
                }

                if (context.UserValue(key: "G05P26Set", value: 1)) {
                    context.State = new StateNumberOnP26(context);
                    return;
                }

                if (context.UserValue(key: "G05P27Set", value: 1)) {
                    context.State = new StateNumberOnP27(context);
                    return;
                }

                if (context.UserValue(key: "G05P28Set", value: 1)) {
                    context.State = new StateNumberOnP28(context);
                    return;
                }

                if (context.UserValue(key: "G05P29Set", value: 1)) {
                    context.State = new StateNumberOnP29(context);
                    return;
                }

                if (context.UserValue(key: "G05P30Set", value: 1)) {
                    context.State = new StateNumberOnP30(context);
                    return;
                }

                if (context.UserValue(key: "G05P31Set", value: 1)) {
                    context.State = new StateNumberOnP31(context);
                    return;
                }

                if (context.UserValue(key: "G05P32Set", value: 1)) {
                    context.State = new StateNumberOnP32(context);
                    return;
                }

                if (context.UserValue(key: "G05P33Set", value: 1)) {
                    context.State = new StateNumberOnP33(context);
                    return;
                }

                if (context.UserValue(key: "G05P34Set", value: 1)) {
                    context.State = new StateNumberOnP34(context);
                    return;
                }

                if (context.UserValue(key: "G05P35Set", value: 1)) {
                    context.State = new StateNumberOnP35(context);
                    return;
                }

                if (context.UserValue(key: "G05P36Set", value: 1)) {
                    context.State = new StateNumberOnP36(context);
                    return;
                }

                if (context.UserValue(key: "G05P37Set", value: 1)) {
                    context.State = new StateNumberOnP37(context);
                    return;
                }

                if (context.UserValue(key: "G05P38Set", value: 1)) {
                    context.State = new StateNumberOnP38(context);
                    return;
                }

                if (context.UserValue(key: "G05P39Set", value: 1)) {
                    context.State = new StateNumberOnP39(context);
                    return;
                }

                if (context.UserValue(key: "G05P40Set", value: 1)) {
                    context.State = new StateNumberOnP40(context);
                    return;
                }

                if (context.UserValue(key: "G05P41Set", value: 1)) {
                    context.State = new StateNumberOnP41(context);
                    return;
                }

                if (context.UserValue(key: "G05P42Set", value: 1)) {
                    context.State = new StateNumberOnP42(context);
                    return;
                }

                if (context.UserValue(key: "G05P43Set", value: 1)) {
                    context.State = new StateNumberOnP43(context);
                    return;
                }

                if (context.UserValue(key: "G05P44Set", value: 1)) {
                    context.State = new StateNumberOnP44(context);
                    return;
                }

                if (context.UserValue(key: "G05P45Set", value: 1)) {
                    context.State = new StateNumberOnP45(context);
                    return;
                }

                if (context.UserValue(key: "G05P46Set", value: 1)) {
                    context.State = new StateNumberOnP46(context);
                    return;
                }

                if (context.UserValue(key: "G05P47Set", value: 1)) {
                    context.State = new StateNumberOnP47(context);
                    return;
                }

                if (context.UserValue(key: "G05P48Set", value: 1)) {
                    context.State = new StateNumberOnP48(context);
                    return;
                }

                if (context.UserValue(key: "G05P49Set", value: 1)) {
                    context.State = new StateNumberOnP49(context);
                    return;
                }

                if (context.UserValue(key: "G05P50Set", value: 1)) {
                    context.State = new StateNumberOnP50(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetUserValue(triggerID: 7110, key: "ColorStart", value: 1);
                context.SetUserValue(triggerID: 7120, key: "ColorStart", value: 1);
                context.SetUserValue(triggerID: 7130, key: "ColorStart", value: 1);
                context.SetUserValue(triggerID: 7140, key: "ColorStart", value: 1);
                context.SetUserValue(triggerID: 7210, key: "ColorStart", value: 1);
                context.SetUserValue(triggerID: 7220, key: "ColorStart", value: 1);
                context.SetUserValue(triggerID: 7230, key: "ColorStart", value: 1);
                context.SetUserValue(triggerID: 7240, key: "ColorStart", value: 1);
                context.SetUserValue(triggerID: 7310, key: "ColorStart", value: 1);
                context.SetUserValue(triggerID: 7320, key: "ColorStart", value: 1);
                context.SetUserValue(triggerID: 7330, key: "ColorStart", value: 1);
                context.SetUserValue(triggerID: 7340, key: "ColorStart", value: 1);
                context.SetUserValue(triggerID: 7410, key: "ColorStart", value: 1);
                context.SetUserValue(triggerID: 7420, key: "ColorStart", value: 1);
                context.SetUserValue(triggerID: 7430, key: "ColorStart", value: 1);
                context.SetUserValue(triggerID: 7440, key: "ColorStart", value: 1);
            }
        }

        private class StateNumberOnP01 : TriggerState {
            internal StateNumberOnP01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new int[] {112}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {121}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {134}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {142}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {215}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {221}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {233}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {245}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {315}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {324}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {331}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {343}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {414}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {423}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {435}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {442}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerID: 8110, key: "Barrier11", value: 2);
                context.SetUserValue(triggerID: 8120, key: "Barrier12", value: 1);
                context.SetUserValue(triggerID: 8130, key: "Barrier13", value: 4);
                context.SetUserValue(triggerID: 8140, key: "Barrier14", value: 2);
                context.SetUserValue(triggerID: 8210, key: "Barrier21", value: 5);
                context.SetUserValue(triggerID: 8220, key: "Barrier22", value: 1);
                context.SetUserValue(triggerID: 8230, key: "Barrier23", value: 3);
                context.SetUserValue(triggerID: 8240, key: "Barrier24", value: 5);
                context.SetUserValue(triggerID: 8310, key: "Barrier31", value: 5);
                context.SetUserValue(triggerID: 8320, key: "Barrier32", value: 4);
                context.SetUserValue(triggerID: 8330, key: "Barrier33", value: 1);
                context.SetUserValue(triggerID: 8340, key: "Barrier34", value: 3);
                context.SetUserValue(triggerID: 8410, key: "Barrier41", value: 4);
                context.SetUserValue(triggerID: 8420, key: "Barrier42", value: 3);
                context.SetUserValue(triggerID: 8430, key: "Barrier43", value: 5);
                context.SetUserValue(triggerID: 8440, key: "Barrier44", value: 2);
            }

            public override void Execute() {
                if (context.UserValue(key: "G05P01TimeLimit", value: 1)) {
                    context.State = new StateCheckP01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP01 : TriggerState {
            internal StateCheckP01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 9110, key: "Box11Check", value: 2);
                context.SetUserValue(triggerID: 9120, key: "Box12Check", value: 1);
                context.SetUserValue(triggerID: 9130, key: "Box13Check", value: 4);
                context.SetUserValue(triggerID: 9140, key: "Box14Check", value: 2);
                context.SetUserValue(triggerID: 9210, key: "Box21Check", value: 5);
                context.SetUserValue(triggerID: 9220, key: "Box22Check", value: 1);
                context.SetUserValue(triggerID: 9230, key: "Box23Check", value: 3);
                context.SetUserValue(triggerID: 9240, key: "Box24Check", value: 5);
                context.SetUserValue(triggerID: 9310, key: "Box31Check", value: 5);
                context.SetUserValue(triggerID: 9320, key: "Box32Check", value: 4);
                context.SetUserValue(triggerID: 9330, key: "Box33Check", value: 1);
                context.SetUserValue(triggerID: 9340, key: "Box34Check", value: 3);
                context.SetUserValue(triggerID: 9410, key: "Box41Check", value: 4);
                context.SetUserValue(triggerID: 9420, key: "Box42Check", value: 3);
                context.SetUserValue(triggerID: 9430, key: "Box43Check", value: 5);
                context.SetUserValue(triggerID: 9440, key: "Box44Check", value: 2);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP01 : TriggerState {
            internal StateNumberOffP01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {112}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {121}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {134}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {142}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {215}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {221}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {233}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {245}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {315}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {324}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {331}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {343}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {414}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {423}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {435}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {442}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP01 : TriggerState {
            internal StateResetP01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 1, key: "G05P01End", value: 1);
                context.SetUserValue(key: "G05P01Set", value: 0);
                context.SetUserValue(key: "G05P01TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP02 : TriggerState {
            internal StateNumberOnP02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new int[] {115}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {124}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {131}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {142}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {211}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {225}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {232}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {243}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {314}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {323}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {335}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {341}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {413}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {422}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {434}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {445}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerID: 8110, key: "Barrier11", value: 5);
                context.SetUserValue(triggerID: 8120, key: "Barrier12", value: 4);
                context.SetUserValue(triggerID: 8130, key: "Barrier13", value: 1);
                context.SetUserValue(triggerID: 8140, key: "Barrier14", value: 2);
                context.SetUserValue(triggerID: 8210, key: "Barrier21", value: 1);
                context.SetUserValue(triggerID: 8220, key: "Barrier22", value: 5);
                context.SetUserValue(triggerID: 8230, key: "Barrier23", value: 2);
                context.SetUserValue(triggerID: 8240, key: "Barrier24", value: 3);
                context.SetUserValue(triggerID: 8310, key: "Barrier31", value: 4);
                context.SetUserValue(triggerID: 8320, key: "Barrier32", value: 3);
                context.SetUserValue(triggerID: 8330, key: "Barrier33", value: 5);
                context.SetUserValue(triggerID: 8340, key: "Barrier34", value: 1);
                context.SetUserValue(triggerID: 8410, key: "Barrier41", value: 3);
                context.SetUserValue(triggerID: 8420, key: "Barrier42", value: 2);
                context.SetUserValue(triggerID: 8430, key: "Barrier43", value: 4);
                context.SetUserValue(triggerID: 8440, key: "Barrier44", value: 5);
            }

            public override void Execute() {
                if (context.UserValue(key: "G05P02TimeLimit", value: 1)) {
                    context.State = new StateCheckP02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP02 : TriggerState {
            internal StateCheckP02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 9110, key: "Box11Check", value: 5);
                context.SetUserValue(triggerID: 9120, key: "Box12Check", value: 4);
                context.SetUserValue(triggerID: 9130, key: "Box13Check", value: 1);
                context.SetUserValue(triggerID: 9140, key: "Box14Check", value: 2);
                context.SetUserValue(triggerID: 9210, key: "Box21Check", value: 1);
                context.SetUserValue(triggerID: 9220, key: "Box22Check", value: 5);
                context.SetUserValue(triggerID: 9230, key: "Box23Check", value: 2);
                context.SetUserValue(triggerID: 9240, key: "Box24Check", value: 3);
                context.SetUserValue(triggerID: 9310, key: "Box31Check", value: 4);
                context.SetUserValue(triggerID: 9320, key: "Box32Check", value: 3);
                context.SetUserValue(triggerID: 9330, key: "Box33Check", value: 5);
                context.SetUserValue(triggerID: 9340, key: "Box34Check", value: 1);
                context.SetUserValue(triggerID: 9410, key: "Box41Check", value: 3);
                context.SetUserValue(triggerID: 9420, key: "Box42Check", value: 2);
                context.SetUserValue(triggerID: 9430, key: "Box43Check", value: 4);
                context.SetUserValue(triggerID: 9440, key: "Box44Check", value: 5);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP02 : TriggerState {
            internal StateNumberOffP02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {115}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {124}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {131}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {142}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {211}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {225}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {232}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {243}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {314}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {323}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {335}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {341}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {413}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {422}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {434}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {445}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP02 : TriggerState {
            internal StateResetP02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 1, key: "G05P02End", value: 1);
                context.SetUserValue(key: "G05P02Set", value: 0);
                context.SetUserValue(key: "G05P02TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP03 : TriggerState {
            internal StateNumberOnP03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new int[] {111}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {124}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {133}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {145}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {211}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {222}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {234}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {243}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {312}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {325}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {334}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {345}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {413}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {422}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {431}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {445}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerID: 8110, key: "Barrier11", value: 1);
                context.SetUserValue(triggerID: 8120, key: "Barrier12", value: 4);
                context.SetUserValue(triggerID: 8130, key: "Barrier13", value: 3);
                context.SetUserValue(triggerID: 8140, key: "Barrier14", value: 5);
                context.SetUserValue(triggerID: 8210, key: "Barrier21", value: 1);
                context.SetUserValue(triggerID: 8220, key: "Barrier22", value: 2);
                context.SetUserValue(triggerID: 8230, key: "Barrier23", value: 4);
                context.SetUserValue(triggerID: 8240, key: "Barrier24", value: 3);
                context.SetUserValue(triggerID: 8310, key: "Barrier31", value: 2);
                context.SetUserValue(triggerID: 8320, key: "Barrier32", value: 5);
                context.SetUserValue(triggerID: 8330, key: "Barrier33", value: 4);
                context.SetUserValue(triggerID: 8340, key: "Barrier34", value: 5);
                context.SetUserValue(triggerID: 8410, key: "Barrier41", value: 3);
                context.SetUserValue(triggerID: 8420, key: "Barrier42", value: 2);
                context.SetUserValue(triggerID: 8430, key: "Barrier43", value: 1);
                context.SetUserValue(triggerID: 8440, key: "Barrier44", value: 5);
            }

            public override void Execute() {
                if (context.UserValue(key: "G05P03TimeLimit", value: 1)) {
                    context.State = new StateCheckP03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP03 : TriggerState {
            internal StateCheckP03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 9110, key: "Box11Check", value: 1);
                context.SetUserValue(triggerID: 9120, key: "Box12Check", value: 4);
                context.SetUserValue(triggerID: 9130, key: "Box13Check", value: 3);
                context.SetUserValue(triggerID: 9140, key: "Box14Check", value: 5);
                context.SetUserValue(triggerID: 9210, key: "Box21Check", value: 1);
                context.SetUserValue(triggerID: 9220, key: "Box22Check", value: 2);
                context.SetUserValue(triggerID: 9230, key: "Box23Check", value: 4);
                context.SetUserValue(triggerID: 9240, key: "Box24Check", value: 3);
                context.SetUserValue(triggerID: 9310, key: "Box31Check", value: 2);
                context.SetUserValue(triggerID: 9320, key: "Box32Check", value: 5);
                context.SetUserValue(triggerID: 9330, key: "Box33Check", value: 4);
                context.SetUserValue(triggerID: 9340, key: "Box34Check", value: 5);
                context.SetUserValue(triggerID: 9410, key: "Box41Check", value: 3);
                context.SetUserValue(triggerID: 9420, key: "Box42Check", value: 2);
                context.SetUserValue(triggerID: 9430, key: "Box43Check", value: 1);
                context.SetUserValue(triggerID: 9440, key: "Box44Check", value: 5);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP03 : TriggerState {
            internal StateNumberOffP03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {111}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {124}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {133}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {145}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {211}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {222}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {234}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {243}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {312}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {325}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {334}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {345}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {413}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {422}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {431}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {445}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP03 : TriggerState {
            internal StateResetP03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 1, key: "G05P03End", value: 1);
                context.SetUserValue(key: "G05P03Set", value: 0);
                context.SetUserValue(key: "G05P03TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP04 : TriggerState {
            internal StateNumberOnP04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new int[] {111}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {125}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {132}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {143}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {212}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {224}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {235}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {241}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {315}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {324}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {333}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {342}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {414}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {423}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {435}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {441}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerID: 8110, key: "Barrier11", value: 1);
                context.SetUserValue(triggerID: 8120, key: "Barrier12", value: 5);
                context.SetUserValue(triggerID: 8130, key: "Barrier13", value: 2);
                context.SetUserValue(triggerID: 8140, key: "Barrier14", value: 3);
                context.SetUserValue(triggerID: 8210, key: "Barrier21", value: 2);
                context.SetUserValue(triggerID: 8220, key: "Barrier22", value: 4);
                context.SetUserValue(triggerID: 8230, key: "Barrier23", value: 5);
                context.SetUserValue(triggerID: 8240, key: "Barrier24", value: 1);
                context.SetUserValue(triggerID: 8310, key: "Barrier31", value: 5);
                context.SetUserValue(triggerID: 8320, key: "Barrier32", value: 4);
                context.SetUserValue(triggerID: 8330, key: "Barrier33", value: 3);
                context.SetUserValue(triggerID: 8340, key: "Barrier34", value: 2);
                context.SetUserValue(triggerID: 8410, key: "Barrier41", value: 4);
                context.SetUserValue(triggerID: 8420, key: "Barrier42", value: 3);
                context.SetUserValue(triggerID: 8430, key: "Barrier43", value: 5);
                context.SetUserValue(triggerID: 8440, key: "Barrier44", value: 1);
            }

            public override void Execute() {
                if (context.UserValue(key: "G05P04TimeLimit", value: 1)) {
                    context.State = new StateCheckP04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP04 : TriggerState {
            internal StateCheckP04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 9110, key: "Box11Check", value: 1);
                context.SetUserValue(triggerID: 9120, key: "Box12Check", value: 5);
                context.SetUserValue(triggerID: 9130, key: "Box13Check", value: 2);
                context.SetUserValue(triggerID: 9140, key: "Box14Check", value: 3);
                context.SetUserValue(triggerID: 9210, key: "Box21Check", value: 2);
                context.SetUserValue(triggerID: 9220, key: "Box22Check", value: 4);
                context.SetUserValue(triggerID: 9230, key: "Box23Check", value: 5);
                context.SetUserValue(triggerID: 9240, key: "Box24Check", value: 1);
                context.SetUserValue(triggerID: 9310, key: "Box31Check", value: 5);
                context.SetUserValue(triggerID: 9320, key: "Box32Check", value: 4);
                context.SetUserValue(triggerID: 9330, key: "Box33Check", value: 3);
                context.SetUserValue(triggerID: 9340, key: "Box34Check", value: 2);
                context.SetUserValue(triggerID: 9410, key: "Box41Check", value: 4);
                context.SetUserValue(triggerID: 9420, key: "Box42Check", value: 3);
                context.SetUserValue(triggerID: 9430, key: "Box43Check", value: 5);
                context.SetUserValue(triggerID: 9440, key: "Box44Check", value: 1);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP04 : TriggerState {
            internal StateNumberOffP04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {111}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {125}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {132}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {143}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {212}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {224}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {235}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {241}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {315}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {324}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {333}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {342}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {414}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {423}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {435}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {441}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP04 : TriggerState {
            internal StateResetP04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 1, key: "G05P04End", value: 1);
                context.SetUserValue(key: "G05P04Set", value: 0);
                context.SetUserValue(key: "G05P04TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP05 : TriggerState {
            internal StateNumberOnP05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new int[] {114}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {123}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {134}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {143}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {214}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {223}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {234}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {244}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {311}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {324}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {333}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {341}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {413}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {424}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {433}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {444}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerID: 8110, key: "Barrier11", value: 4);
                context.SetUserValue(triggerID: 8120, key: "Barrier12", value: 3);
                context.SetUserValue(triggerID: 8130, key: "Barrier13", value: 4);
                context.SetUserValue(triggerID: 8140, key: "Barrier14", value: 3);
                context.SetUserValue(triggerID: 8210, key: "Barrier21", value: 4);
                context.SetUserValue(triggerID: 8220, key: "Barrier22", value: 3);
                context.SetUserValue(triggerID: 8230, key: "Barrier23", value: 4);
                context.SetUserValue(triggerID: 8240, key: "Barrier24", value: 4);
                context.SetUserValue(triggerID: 8310, key: "Barrier31", value: 1);
                context.SetUserValue(triggerID: 8320, key: "Barrier32", value: 4);
                context.SetUserValue(triggerID: 8330, key: "Barrier33", value: 3);
                context.SetUserValue(triggerID: 8340, key: "Barrier34", value: 1);
                context.SetUserValue(triggerID: 8410, key: "Barrier41", value: 3);
                context.SetUserValue(triggerID: 8420, key: "Barrier42", value: 4);
                context.SetUserValue(triggerID: 8430, key: "Barrier43", value: 3);
                context.SetUserValue(triggerID: 8440, key: "Barrier44", value: 4);
            }

            public override void Execute() {
                if (context.UserValue(key: "G05P05TimeLimit", value: 1)) {
                    context.State = new StateCheckP05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP05 : TriggerState {
            internal StateCheckP05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 9110, key: "Box11Check", value: 4);
                context.SetUserValue(triggerID: 9120, key: "Box12Check", value: 3);
                context.SetUserValue(triggerID: 9130, key: "Box13Check", value: 4);
                context.SetUserValue(triggerID: 9140, key: "Box14Check", value: 3);
                context.SetUserValue(triggerID: 9210, key: "Box21Check", value: 4);
                context.SetUserValue(triggerID: 9220, key: "Box22Check", value: 3);
                context.SetUserValue(triggerID: 9230, key: "Box23Check", value: 4);
                context.SetUserValue(triggerID: 9240, key: "Box24Check", value: 4);
                context.SetUserValue(triggerID: 9310, key: "Box31Check", value: 1);
                context.SetUserValue(triggerID: 9320, key: "Box32Check", value: 4);
                context.SetUserValue(triggerID: 9330, key: "Box33Check", value: 3);
                context.SetUserValue(triggerID: 9340, key: "Box34Check", value: 1);
                context.SetUserValue(triggerID: 9410, key: "Box41Check", value: 3);
                context.SetUserValue(triggerID: 9420, key: "Box42Check", value: 4);
                context.SetUserValue(triggerID: 9430, key: "Box43Check", value: 3);
                context.SetUserValue(triggerID: 9440, key: "Box44Check", value: 4);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP05 : TriggerState {
            internal StateNumberOffP05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {114}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {123}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {134}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {143}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {214}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {223}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {234}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {244}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {311}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {324}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {333}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {341}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {413}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {424}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {433}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {444}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP05 : TriggerState {
            internal StateResetP05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 1, key: "G05P05End", value: 1);
                context.SetUserValue(key: "G05P05Set", value: 0);
                context.SetUserValue(key: "G05P05TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP06 : TriggerState {
            internal StateNumberOnP06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new int[] {112}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {125}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {131}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {145}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {211}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {225}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {235}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {242}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {313}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {325}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {335}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {341}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {415}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {421}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {435}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {443}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerID: 8110, key: "Barrier11", value: 2);
                context.SetUserValue(triggerID: 8120, key: "Barrier12", value: 5);
                context.SetUserValue(triggerID: 8130, key: "Barrier13", value: 1);
                context.SetUserValue(triggerID: 8140, key: "Barrier14", value: 5);
                context.SetUserValue(triggerID: 8210, key: "Barrier21", value: 1);
                context.SetUserValue(triggerID: 8220, key: "Barrier22", value: 5);
                context.SetUserValue(triggerID: 8230, key: "Barrier23", value: 5);
                context.SetUserValue(triggerID: 8240, key: "Barrier24", value: 2);
                context.SetUserValue(triggerID: 8310, key: "Barrier31", value: 3);
                context.SetUserValue(triggerID: 8320, key: "Barrier32", value: 5);
                context.SetUserValue(triggerID: 8330, key: "Barrier33", value: 5);
                context.SetUserValue(triggerID: 8340, key: "Barrier34", value: 1);
                context.SetUserValue(triggerID: 8410, key: "Barrier41", value: 5);
                context.SetUserValue(triggerID: 8420, key: "Barrier42", value: 1);
                context.SetUserValue(triggerID: 8430, key: "Barrier43", value: 5);
                context.SetUserValue(triggerID: 8440, key: "Barrier44", value: 3);
            }

            public override void Execute() {
                if (context.UserValue(key: "G05P06TimeLimit", value: 1)) {
                    context.State = new StateCheckP06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP06 : TriggerState {
            internal StateCheckP06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 9110, key: "Box11Check", value: 2);
                context.SetUserValue(triggerID: 9120, key: "Box12Check", value: 5);
                context.SetUserValue(triggerID: 9130, key: "Box13Check", value: 1);
                context.SetUserValue(triggerID: 9140, key: "Box14Check", value: 5);
                context.SetUserValue(triggerID: 9210, key: "Box21Check", value: 1);
                context.SetUserValue(triggerID: 9220, key: "Box22Check", value: 5);
                context.SetUserValue(triggerID: 9230, key: "Box23Check", value: 5);
                context.SetUserValue(triggerID: 9240, key: "Box24Check", value: 2);
                context.SetUserValue(triggerID: 9310, key: "Box31Check", value: 3);
                context.SetUserValue(triggerID: 9320, key: "Box32Check", value: 5);
                context.SetUserValue(triggerID: 9330, key: "Box33Check", value: 5);
                context.SetUserValue(triggerID: 9340, key: "Box34Check", value: 1);
                context.SetUserValue(triggerID: 9410, key: "Box41Check", value: 5);
                context.SetUserValue(triggerID: 9420, key: "Box42Check", value: 1);
                context.SetUserValue(triggerID: 9430, key: "Box43Check", value: 5);
                context.SetUserValue(triggerID: 9440, key: "Box44Check", value: 3);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP06 : TriggerState {
            internal StateNumberOffP06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {112}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {125}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {131}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {145}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {211}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {225}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {235}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {242}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {313}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {325}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {335}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {341}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {415}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {421}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {435}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {443}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP06 : TriggerState {
            internal StateResetP06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 1, key: "G05P06End", value: 1);
                context.SetUserValue(key: "G05P06Set", value: 0);
                context.SetUserValue(key: "G05P06TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP07 : TriggerState {
            internal StateNumberOnP07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new int[] {115}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {120}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {131}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {145}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {215}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {221}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {235}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {240}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {311}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {325}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {335}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {341}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {415}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {425}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {435}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {445}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerID: 8110, key: "Barrier11", value: 5);
                context.SetUserValue(triggerID: 8120, key: "Barrier12", value: 0);
                context.SetUserValue(triggerID: 8130, key: "Barrier13", value: 1);
                context.SetUserValue(triggerID: 8140, key: "Barrier14", value: 5);
                context.SetUserValue(triggerID: 8210, key: "Barrier21", value: 5);
                context.SetUserValue(triggerID: 8220, key: "Barrier22", value: 1);
                context.SetUserValue(triggerID: 8230, key: "Barrier23", value: 5);
                context.SetUserValue(triggerID: 8240, key: "Barrier24", value: 0);
                context.SetUserValue(triggerID: 8310, key: "Barrier31", value: 1);
                context.SetUserValue(triggerID: 8320, key: "Barrier32", value: 5);
                context.SetUserValue(triggerID: 8330, key: "Barrier33", value: 5);
                context.SetUserValue(triggerID: 8340, key: "Barrier34", value: 1);
                context.SetUserValue(triggerID: 8410, key: "Barrier41", value: 5);
                context.SetUserValue(triggerID: 8420, key: "Barrier42", value: 5);
                context.SetUserValue(triggerID: 8430, key: "Barrier43", value: 5);
                context.SetUserValue(triggerID: 8440, key: "Barrier44", value: 5);
            }

            public override void Execute() {
                if (context.UserValue(key: "G05P07TimeLimit", value: 1)) {
                    context.State = new StateCheckP07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP07 : TriggerState {
            internal StateCheckP07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 9110, key: "Box11Check", value: 5);
                context.SetUserValue(triggerID: 9120, key: "Box12Check", value: 0);
                context.SetUserValue(triggerID: 9130, key: "Box13Check", value: 1);
                context.SetUserValue(triggerID: 9140, key: "Box14Check", value: 5);
                context.SetUserValue(triggerID: 9210, key: "Box21Check", value: 5);
                context.SetUserValue(triggerID: 9220, key: "Box22Check", value: 1);
                context.SetUserValue(triggerID: 9230, key: "Box23Check", value: 5);
                context.SetUserValue(triggerID: 9240, key: "Box24Check", value: 0);
                context.SetUserValue(triggerID: 9310, key: "Box31Check", value: 1);
                context.SetUserValue(triggerID: 9320, key: "Box32Check", value: 5);
                context.SetUserValue(triggerID: 9330, key: "Box33Check", value: 5);
                context.SetUserValue(triggerID: 9340, key: "Box34Check", value: 1);
                context.SetUserValue(triggerID: 9410, key: "Box41Check", value: 5);
                context.SetUserValue(triggerID: 9420, key: "Box42Check", value: 5);
                context.SetUserValue(triggerID: 9430, key: "Box43Check", value: 5);
                context.SetUserValue(triggerID: 9440, key: "Box44Check", value: 5);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP07 : TriggerState {
            internal StateNumberOffP07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {115}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {120}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {131}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {145}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {215}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {221}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {235}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {240}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {311}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {325}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {335}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {341}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {415}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {425}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {435}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {445}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP07 : TriggerState {
            internal StateResetP07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 1, key: "G05P07End", value: 1);
                context.SetUserValue(key: "G05P07Set", value: 0);
                context.SetUserValue(key: "G05P07TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP08 : TriggerState {
            internal StateNumberOnP08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new int[] {114}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {122}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {135}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {144}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {212}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {225}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {231}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {244}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {315}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {322}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {334}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {345}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {414}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {422}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {434}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {442}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerID: 8110, key: "Barrier11", value: 4);
                context.SetUserValue(triggerID: 8120, key: "Barrier12", value: 2);
                context.SetUserValue(triggerID: 8130, key: "Barrier13", value: 5);
                context.SetUserValue(triggerID: 8140, key: "Barrier14", value: 4);
                context.SetUserValue(triggerID: 8210, key: "Barrier21", value: 2);
                context.SetUserValue(triggerID: 8220, key: "Barrier22", value: 5);
                context.SetUserValue(triggerID: 8230, key: "Barrier23", value: 1);
                context.SetUserValue(triggerID: 8240, key: "Barrier24", value: 4);
                context.SetUserValue(triggerID: 8310, key: "Barrier31", value: 5);
                context.SetUserValue(triggerID: 8320, key: "Barrier32", value: 2);
                context.SetUserValue(triggerID: 8330, key: "Barrier33", value: 4);
                context.SetUserValue(triggerID: 8340, key: "Barrier34", value: 5);
                context.SetUserValue(triggerID: 8410, key: "Barrier41", value: 4);
                context.SetUserValue(triggerID: 8420, key: "Barrier42", value: 2);
                context.SetUserValue(triggerID: 8430, key: "Barrier43", value: 4);
                context.SetUserValue(triggerID: 8440, key: "Barrier44", value: 2);
            }

            public override void Execute() {
                if (context.UserValue(key: "G05P08TimeLimit", value: 1)) {
                    context.State = new StateCheckP08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP08 : TriggerState {
            internal StateCheckP08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 9110, key: "Box11Check", value: 4);
                context.SetUserValue(triggerID: 9120, key: "Box12Check", value: 2);
                context.SetUserValue(triggerID: 9130, key: "Box13Check", value: 5);
                context.SetUserValue(triggerID: 9140, key: "Box14Check", value: 4);
                context.SetUserValue(triggerID: 9210, key: "Box21Check", value: 2);
                context.SetUserValue(triggerID: 9220, key: "Box22Check", value: 5);
                context.SetUserValue(triggerID: 9230, key: "Box23Check", value: 1);
                context.SetUserValue(triggerID: 9240, key: "Box24Check", value: 4);
                context.SetUserValue(triggerID: 9310, key: "Box31Check", value: 5);
                context.SetUserValue(triggerID: 9320, key: "Box32Check", value: 2);
                context.SetUserValue(triggerID: 9330, key: "Box33Check", value: 4);
                context.SetUserValue(triggerID: 9340, key: "Box34Check", value: 5);
                context.SetUserValue(triggerID: 9410, key: "Box41Check", value: 4);
                context.SetUserValue(triggerID: 9420, key: "Box42Check", value: 2);
                context.SetUserValue(triggerID: 9430, key: "Box43Check", value: 4);
                context.SetUserValue(triggerID: 9440, key: "Box44Check", value: 2);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP08 : TriggerState {
            internal StateNumberOffP08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {114}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {122}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {135}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {144}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {212}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {225}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {231}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {244}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {315}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {322}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {334}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {345}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {414}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {422}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {434}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {442}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP08 : TriggerState {
            internal StateResetP08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 1, key: "G05P08End", value: 1);
                context.SetUserValue(key: "G05P08Set", value: 0);
                context.SetUserValue(key: "G05P08TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP09 : TriggerState {
            internal StateNumberOnP09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new int[] {115}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {123}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {135}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {141}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {213}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {225}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {233}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {241}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {311}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {323}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {335}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {343}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {413}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {425}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {433}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {445}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerID: 8110, key: "Barrier11", value: 5);
                context.SetUserValue(triggerID: 8120, key: "Barrier12", value: 3);
                context.SetUserValue(triggerID: 8130, key: "Barrier13", value: 5);
                context.SetUserValue(triggerID: 8140, key: "Barrier14", value: 1);
                context.SetUserValue(triggerID: 8210, key: "Barrier21", value: 3);
                context.SetUserValue(triggerID: 8220, key: "Barrier22", value: 5);
                context.SetUserValue(triggerID: 8230, key: "Barrier23", value: 3);
                context.SetUserValue(triggerID: 8240, key: "Barrier24", value: 1);
                context.SetUserValue(triggerID: 8310, key: "Barrier31", value: 1);
                context.SetUserValue(triggerID: 8320, key: "Barrier32", value: 3);
                context.SetUserValue(triggerID: 8330, key: "Barrier33", value: 5);
                context.SetUserValue(triggerID: 8340, key: "Barrier34", value: 3);
                context.SetUserValue(triggerID: 8410, key: "Barrier41", value: 3);
                context.SetUserValue(triggerID: 8420, key: "Barrier42", value: 5);
                context.SetUserValue(triggerID: 8430, key: "Barrier43", value: 3);
                context.SetUserValue(triggerID: 8440, key: "Barrier44", value: 5);
            }

            public override void Execute() {
                if (context.UserValue(key: "G05P09TimeLimit", value: 1)) {
                    context.State = new StateCheckP09(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP09 : TriggerState {
            internal StateCheckP09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 9110, key: "Box11Check", value: 5);
                context.SetUserValue(triggerID: 9120, key: "Box12Check", value: 3);
                context.SetUserValue(triggerID: 9130, key: "Box13Check", value: 5);
                context.SetUserValue(triggerID: 9140, key: "Box14Check", value: 1);
                context.SetUserValue(triggerID: 9210, key: "Box21Check", value: 3);
                context.SetUserValue(triggerID: 9220, key: "Box22Check", value: 5);
                context.SetUserValue(triggerID: 9230, key: "Box23Check", value: 3);
                context.SetUserValue(triggerID: 9240, key: "Box24Check", value: 1);
                context.SetUserValue(triggerID: 9310, key: "Box31Check", value: 1);
                context.SetUserValue(triggerID: 9320, key: "Box32Check", value: 3);
                context.SetUserValue(triggerID: 9330, key: "Box33Check", value: 5);
                context.SetUserValue(triggerID: 9340, key: "Box34Check", value: 3);
                context.SetUserValue(triggerID: 9410, key: "Box41Check", value: 3);
                context.SetUserValue(triggerID: 9420, key: "Box42Check", value: 5);
                context.SetUserValue(triggerID: 9430, key: "Box43Check", value: 3);
                context.SetUserValue(triggerID: 9440, key: "Box44Check", value: 5);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP09(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP09 : TriggerState {
            internal StateNumberOffP09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {115}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {123}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {135}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {141}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {213}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {225}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {233}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {241}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {311}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {323}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {335}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {343}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {413}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {425}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {433}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {445}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP09(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP09 : TriggerState {
            internal StateResetP09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 1, key: "G05P09End", value: 1);
                context.SetUserValue(key: "G05P09Set", value: 0);
                context.SetUserValue(key: "G05P09TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP10 : TriggerState {
            internal StateNumberOnP10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new int[] {111}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {124}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {134}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {144}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {214}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {224}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {230}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {244}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {314}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {321}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {334}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {344}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {414}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {424}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {434}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {441}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerID: 8110, key: "Barrier11", value: 1);
                context.SetUserValue(triggerID: 8120, key: "Barrier12", value: 4);
                context.SetUserValue(triggerID: 8130, key: "Barrier13", value: 4);
                context.SetUserValue(triggerID: 8140, key: "Barrier14", value: 4);
                context.SetUserValue(triggerID: 8210, key: "Barrier21", value: 4);
                context.SetUserValue(triggerID: 8220, key: "Barrier22", value: 4);
                context.SetUserValue(triggerID: 8230, key: "Barrier23", value: 0);
                context.SetUserValue(triggerID: 8240, key: "Barrier24", value: 4);
                context.SetUserValue(triggerID: 8310, key: "Barrier31", value: 4);
                context.SetUserValue(triggerID: 8320, key: "Barrier32", value: 1);
                context.SetUserValue(triggerID: 8330, key: "Barrier33", value: 4);
                context.SetUserValue(triggerID: 8340, key: "Barrier34", value: 4);
                context.SetUserValue(triggerID: 8410, key: "Barrier41", value: 4);
                context.SetUserValue(triggerID: 8420, key: "Barrier42", value: 4);
                context.SetUserValue(triggerID: 8430, key: "Barrier43", value: 4);
                context.SetUserValue(triggerID: 8440, key: "Barrier44", value: 1);
            }

            public override void Execute() {
                if (context.UserValue(key: "G05P10TimeLimit", value: 1)) {
                    context.State = new StateCheckP10(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP10 : TriggerState {
            internal StateCheckP10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 9110, key: "Box11Check", value: 1);
                context.SetUserValue(triggerID: 9120, key: "Box12Check", value: 4);
                context.SetUserValue(triggerID: 9130, key: "Box13Check", value: 4);
                context.SetUserValue(triggerID: 9140, key: "Box14Check", value: 4);
                context.SetUserValue(triggerID: 9210, key: "Box21Check", value: 4);
                context.SetUserValue(triggerID: 9220, key: "Box22Check", value: 4);
                context.SetUserValue(triggerID: 9230, key: "Box23Check", value: 0);
                context.SetUserValue(triggerID: 9240, key: "Box24Check", value: 4);
                context.SetUserValue(triggerID: 9310, key: "Box31Check", value: 4);
                context.SetUserValue(triggerID: 9320, key: "Box32Check", value: 1);
                context.SetUserValue(triggerID: 9330, key: "Box33Check", value: 4);
                context.SetUserValue(triggerID: 9340, key: "Box34Check", value: 4);
                context.SetUserValue(triggerID: 9410, key: "Box41Check", value: 4);
                context.SetUserValue(triggerID: 9420, key: "Box42Check", value: 4);
                context.SetUserValue(triggerID: 9430, key: "Box43Check", value: 4);
                context.SetUserValue(triggerID: 9440, key: "Box44Check", value: 1);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP10(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP10 : TriggerState {
            internal StateNumberOffP10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {111}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {124}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {134}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {144}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {214}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {224}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {230}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {244}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {314}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {321}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {334}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {344}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {414}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {424}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {434}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {441}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP10(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP10 : TriggerState {
            internal StateResetP10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 1, key: "G05P10End", value: 1);
                context.SetUserValue(key: "G05P10Set", value: 0);
                context.SetUserValue(key: "G05P10TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP11 : TriggerState {
            internal StateNumberOnP11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new int[] {115}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {125}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {131}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {145}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {211}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {225}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {235}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {245}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {311}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {325}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {335}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {341}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {415}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {421}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {435}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {445}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerID: 8110, key: "Barrier11", value: 5);
                context.SetUserValue(triggerID: 8120, key: "Barrier12", value: 5);
                context.SetUserValue(triggerID: 8130, key: "Barrier13", value: 1);
                context.SetUserValue(triggerID: 8140, key: "Barrier14", value: 5);
                context.SetUserValue(triggerID: 8210, key: "Barrier21", value: 1);
                context.SetUserValue(triggerID: 8220, key: "Barrier22", value: 5);
                context.SetUserValue(triggerID: 8230, key: "Barrier23", value: 5);
                context.SetUserValue(triggerID: 8240, key: "Barrier24", value: 5);
                context.SetUserValue(triggerID: 8310, key: "Barrier31", value: 1);
                context.SetUserValue(triggerID: 8320, key: "Barrier32", value: 5);
                context.SetUserValue(triggerID: 8330, key: "Barrier33", value: 5);
                context.SetUserValue(triggerID: 8340, key: "Barrier34", value: 1);
                context.SetUserValue(triggerID: 8410, key: "Barrier41", value: 5);
                context.SetUserValue(triggerID: 8420, key: "Barrier42", value: 1);
                context.SetUserValue(triggerID: 8430, key: "Barrier43", value: 5);
                context.SetUserValue(triggerID: 8440, key: "Barrier44", value: 5);
            }

            public override void Execute() {
                if (context.UserValue(key: "G05P11TimeLimit", value: 1)) {
                    context.State = new StateCheckP11(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP11 : TriggerState {
            internal StateCheckP11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 9110, key: "Box11Check", value: 5);
                context.SetUserValue(triggerID: 9120, key: "Box12Check", value: 5);
                context.SetUserValue(triggerID: 9130, key: "Box13Check", value: 1);
                context.SetUserValue(triggerID: 9140, key: "Box14Check", value: 5);
                context.SetUserValue(triggerID: 9210, key: "Box21Check", value: 1);
                context.SetUserValue(triggerID: 9220, key: "Box22Check", value: 5);
                context.SetUserValue(triggerID: 9230, key: "Box23Check", value: 5);
                context.SetUserValue(triggerID: 9240, key: "Box24Check", value: 5);
                context.SetUserValue(triggerID: 9310, key: "Box31Check", value: 1);
                context.SetUserValue(triggerID: 9320, key: "Box32Check", value: 5);
                context.SetUserValue(triggerID: 9330, key: "Box33Check", value: 5);
                context.SetUserValue(triggerID: 9340, key: "Box34Check", value: 1);
                context.SetUserValue(triggerID: 9410, key: "Box41Check", value: 5);
                context.SetUserValue(triggerID: 9420, key: "Box42Check", value: 1);
                context.SetUserValue(triggerID: 9430, key: "Box43Check", value: 5);
                context.SetUserValue(triggerID: 9440, key: "Box44Check", value: 5);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP11(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP11 : TriggerState {
            internal StateNumberOffP11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {115}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {125}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {131}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {145}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {211}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {225}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {235}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {245}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {311}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {325}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {335}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {341}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {415}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {421}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {435}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {445}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP11(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP11 : TriggerState {
            internal StateResetP11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 1, key: "G05P11End", value: 1);
                context.SetUserValue(key: "G05P11Set", value: 0);
                context.SetUserValue(key: "G05P11TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP12 : TriggerState {
            internal StateNumberOnP12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new int[] {113}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {123}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {135}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {145}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {213}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {221}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {235}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {242}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {312}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {325}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {331}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {345}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {415}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {423}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {435}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {443}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerID: 8110, key: "Barrier11", value: 3);
                context.SetUserValue(triggerID: 8120, key: "Barrier12", value: 3);
                context.SetUserValue(triggerID: 8130, key: "Barrier13", value: 5);
                context.SetUserValue(triggerID: 8140, key: "Barrier14", value: 5);
                context.SetUserValue(triggerID: 8210, key: "Barrier21", value: 3);
                context.SetUserValue(triggerID: 8220, key: "Barrier22", value: 1);
                context.SetUserValue(triggerID: 8230, key: "Barrier23", value: 5);
                context.SetUserValue(triggerID: 8240, key: "Barrier24", value: 2);
                context.SetUserValue(triggerID: 8310, key: "Barrier31", value: 2);
                context.SetUserValue(triggerID: 8320, key: "Barrier32", value: 5);
                context.SetUserValue(triggerID: 8330, key: "Barrier33", value: 1);
                context.SetUserValue(triggerID: 8340, key: "Barrier34", value: 5);
                context.SetUserValue(triggerID: 8410, key: "Barrier41", value: 5);
                context.SetUserValue(triggerID: 8420, key: "Barrier42", value: 3);
                context.SetUserValue(triggerID: 8430, key: "Barrier43", value: 5);
                context.SetUserValue(triggerID: 8440, key: "Barrier44", value: 3);
            }

            public override void Execute() {
                if (context.UserValue(key: "G05P12TimeLimit", value: 1)) {
                    context.State = new StateCheckP12(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP12 : TriggerState {
            internal StateCheckP12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 9110, key: "Box11Check", value: 3);
                context.SetUserValue(triggerID: 9120, key: "Box12Check", value: 3);
                context.SetUserValue(triggerID: 9130, key: "Box13Check", value: 5);
                context.SetUserValue(triggerID: 9140, key: "Box14Check", value: 5);
                context.SetUserValue(triggerID: 9210, key: "Box21Check", value: 3);
                context.SetUserValue(triggerID: 9220, key: "Box22Check", value: 1);
                context.SetUserValue(triggerID: 9230, key: "Box23Check", value: 5);
                context.SetUserValue(triggerID: 9240, key: "Box24Check", value: 2);
                context.SetUserValue(triggerID: 9310, key: "Box31Check", value: 2);
                context.SetUserValue(triggerID: 9320, key: "Box32Check", value: 5);
                context.SetUserValue(triggerID: 9330, key: "Box33Check", value: 1);
                context.SetUserValue(triggerID: 9340, key: "Box34Check", value: 5);
                context.SetUserValue(triggerID: 9410, key: "Box41Check", value: 5);
                context.SetUserValue(triggerID: 9420, key: "Box42Check", value: 3);
                context.SetUserValue(triggerID: 9430, key: "Box43Check", value: 5);
                context.SetUserValue(triggerID: 9440, key: "Box44Check", value: 3);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP12(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP12 : TriggerState {
            internal StateNumberOffP12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {113}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {123}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {135}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {145}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {213}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {221}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {235}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {242}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {312}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {325}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {331}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {345}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {415}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {423}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {435}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {443}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP12(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP12 : TriggerState {
            internal StateResetP12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 1, key: "G05P12End", value: 1);
                context.SetUserValue(key: "G05P12Set", value: 0);
                context.SetUserValue(key: "G05P12TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP13 : TriggerState {
            internal StateNumberOnP13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new int[] {113}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {121}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {135}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {144}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {212}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {225}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {231}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {243}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {315}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {324}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {332}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {345}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {414}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {421}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {433}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {442}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerID: 8110, key: "Barrier11", value: 3);
                context.SetUserValue(triggerID: 8120, key: "Barrier12", value: 1);
                context.SetUserValue(triggerID: 8130, key: "Barrier13", value: 5);
                context.SetUserValue(triggerID: 8140, key: "Barrier14", value: 4);
                context.SetUserValue(triggerID: 8210, key: "Barrier21", value: 2);
                context.SetUserValue(triggerID: 8220, key: "Barrier22", value: 5);
                context.SetUserValue(triggerID: 8230, key: "Barrier23", value: 1);
                context.SetUserValue(triggerID: 8240, key: "Barrier24", value: 3);
                context.SetUserValue(triggerID: 8310, key: "Barrier31", value: 5);
                context.SetUserValue(triggerID: 8320, key: "Barrier32", value: 4);
                context.SetUserValue(triggerID: 8330, key: "Barrier33", value: 2);
                context.SetUserValue(triggerID: 8340, key: "Barrier34", value: 5);
                context.SetUserValue(triggerID: 8410, key: "Barrier41", value: 4);
                context.SetUserValue(triggerID: 8420, key: "Barrier42", value: 1);
                context.SetUserValue(triggerID: 8430, key: "Barrier43", value: 3);
                context.SetUserValue(triggerID: 8440, key: "Barrier44", value: 2);
            }

            public override void Execute() {
                if (context.UserValue(key: "G05P13TimeLimit", value: 1)) {
                    context.State = new StateCheckP13(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP13 : TriggerState {
            internal StateCheckP13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 9110, key: "Box11Check", value: 3);
                context.SetUserValue(triggerID: 9120, key: "Box12Check", value: 1);
                context.SetUserValue(triggerID: 9130, key: "Box13Check", value: 5);
                context.SetUserValue(triggerID: 9140, key: "Box14Check", value: 4);
                context.SetUserValue(triggerID: 9210, key: "Box21Check", value: 2);
                context.SetUserValue(triggerID: 9220, key: "Box22Check", value: 5);
                context.SetUserValue(triggerID: 9230, key: "Box23Check", value: 1);
                context.SetUserValue(triggerID: 9240, key: "Box24Check", value: 3);
                context.SetUserValue(triggerID: 9310, key: "Box31Check", value: 5);
                context.SetUserValue(triggerID: 9320, key: "Box32Check", value: 4);
                context.SetUserValue(triggerID: 9330, key: "Box33Check", value: 2);
                context.SetUserValue(triggerID: 9340, key: "Box34Check", value: 5);
                context.SetUserValue(triggerID: 9410, key: "Box41Check", value: 4);
                context.SetUserValue(triggerID: 9420, key: "Box42Check", value: 1);
                context.SetUserValue(triggerID: 9430, key: "Box43Check", value: 3);
                context.SetUserValue(triggerID: 9440, key: "Box44Check", value: 2);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP13(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP13 : TriggerState {
            internal StateNumberOffP13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {113}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {121}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {135}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {144}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {212}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {225}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {231}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {243}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {315}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {324}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {332}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {345}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {414}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {421}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {433}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {442}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP13(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP13 : TriggerState {
            internal StateResetP13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 1, key: "G05P13End", value: 1);
                context.SetUserValue(key: "G05P13Set", value: 0);
                context.SetUserValue(key: "G05P13TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP14 : TriggerState {
            internal StateNumberOnP14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new int[] {112}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {124}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {133}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {141}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {213}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {225}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {235}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {241}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {312}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {325}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {335}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {343}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {414}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {421}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {432}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {444}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerID: 8110, key: "Barrier11", value: 2);
                context.SetUserValue(triggerID: 8120, key: "Barrier12", value: 4);
                context.SetUserValue(triggerID: 8130, key: "Barrier13", value: 3);
                context.SetUserValue(triggerID: 8140, key: "Barrier14", value: 1);
                context.SetUserValue(triggerID: 8210, key: "Barrier21", value: 3);
                context.SetUserValue(triggerID: 8220, key: "Barrier22", value: 5);
                context.SetUserValue(triggerID: 8230, key: "Barrier23", value: 5);
                context.SetUserValue(triggerID: 8240, key: "Barrier24", value: 1);
                context.SetUserValue(triggerID: 8310, key: "Barrier31", value: 2);
                context.SetUserValue(triggerID: 8320, key: "Barrier32", value: 5);
                context.SetUserValue(triggerID: 8330, key: "Barrier33", value: 5);
                context.SetUserValue(triggerID: 8340, key: "Barrier34", value: 3);
                context.SetUserValue(triggerID: 8410, key: "Barrier41", value: 4);
                context.SetUserValue(triggerID: 8420, key: "Barrier42", value: 1);
                context.SetUserValue(triggerID: 8430, key: "Barrier43", value: 2);
                context.SetUserValue(triggerID: 8440, key: "Barrier44", value: 4);
            }

            public override void Execute() {
                if (context.UserValue(key: "G05P14TimeLimit", value: 1)) {
                    context.State = new StateCheckP14(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP14 : TriggerState {
            internal StateCheckP14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 9110, key: "Box11Check", value: 2);
                context.SetUserValue(triggerID: 9120, key: "Box12Check", value: 4);
                context.SetUserValue(triggerID: 9130, key: "Box13Check", value: 3);
                context.SetUserValue(triggerID: 9140, key: "Box14Check", value: 1);
                context.SetUserValue(triggerID: 9210, key: "Box21Check", value: 3);
                context.SetUserValue(triggerID: 9220, key: "Box22Check", value: 5);
                context.SetUserValue(triggerID: 9230, key: "Box23Check", value: 5);
                context.SetUserValue(triggerID: 9240, key: "Box24Check", value: 1);
                context.SetUserValue(triggerID: 9310, key: "Box31Check", value: 2);
                context.SetUserValue(triggerID: 9320, key: "Box32Check", value: 5);
                context.SetUserValue(triggerID: 9330, key: "Box33Check", value: 5);
                context.SetUserValue(triggerID: 9340, key: "Box34Check", value: 3);
                context.SetUserValue(triggerID: 9410, key: "Box41Check", value: 4);
                context.SetUserValue(triggerID: 9420, key: "Box42Check", value: 1);
                context.SetUserValue(triggerID: 9430, key: "Box43Check", value: 2);
                context.SetUserValue(triggerID: 9440, key: "Box44Check", value: 4);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP14(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP14 : TriggerState {
            internal StateNumberOffP14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {112}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {124}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {133}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {141}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {213}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {225}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {235}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {241}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {312}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {325}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {335}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {343}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {414}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {421}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {432}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {444}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP14(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP14 : TriggerState {
            internal StateResetP14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 1, key: "G05P14End", value: 1);
                context.SetUserValue(key: "G05P14Set", value: 0);
                context.SetUserValue(key: "G05P14TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP15 : TriggerState {
            internal StateNumberOnP15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new int[] {111}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {125}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {133}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {145}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {212}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {224}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {232}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {245}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {313}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {325}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {331}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {344}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {413}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {421}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {434}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {442}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerID: 8110, key: "Barrier11", value: 1);
                context.SetUserValue(triggerID: 8120, key: "Barrier12", value: 5);
                context.SetUserValue(triggerID: 8130, key: "Barrier13", value: 3);
                context.SetUserValue(triggerID: 8140, key: "Barrier14", value: 5);
                context.SetUserValue(triggerID: 8210, key: "Barrier21", value: 2);
                context.SetUserValue(triggerID: 8220, key: "Barrier22", value: 4);
                context.SetUserValue(triggerID: 8230, key: "Barrier23", value: 2);
                context.SetUserValue(triggerID: 8240, key: "Barrier24", value: 5);
                context.SetUserValue(triggerID: 8310, key: "Barrier31", value: 3);
                context.SetUserValue(triggerID: 8320, key: "Barrier32", value: 5);
                context.SetUserValue(triggerID: 8330, key: "Barrier33", value: 1);
                context.SetUserValue(triggerID: 8340, key: "Barrier34", value: 4);
                context.SetUserValue(triggerID: 8410, key: "Barrier41", value: 3);
                context.SetUserValue(triggerID: 8420, key: "Barrier42", value: 1);
                context.SetUserValue(triggerID: 8430, key: "Barrier43", value: 4);
                context.SetUserValue(triggerID: 8440, key: "Barrier44", value: 2);
            }

            public override void Execute() {
                if (context.UserValue(key: "G05P15TimeLimit", value: 1)) {
                    context.State = new StateCheckP15(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP15 : TriggerState {
            internal StateCheckP15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 9110, key: "Box11Check", value: 1);
                context.SetUserValue(triggerID: 9120, key: "Box12Check", value: 5);
                context.SetUserValue(triggerID: 9130, key: "Box13Check", value: 3);
                context.SetUserValue(triggerID: 9140, key: "Box14Check", value: 5);
                context.SetUserValue(triggerID: 9210, key: "Box21Check", value: 2);
                context.SetUserValue(triggerID: 9220, key: "Box22Check", value: 4);
                context.SetUserValue(triggerID: 9230, key: "Box23Check", value: 2);
                context.SetUserValue(triggerID: 9240, key: "Box24Check", value: 5);
                context.SetUserValue(triggerID: 9310, key: "Box31Check", value: 3);
                context.SetUserValue(triggerID: 9320, key: "Box32Check", value: 5);
                context.SetUserValue(triggerID: 9330, key: "Box33Check", value: 1);
                context.SetUserValue(triggerID: 9340, key: "Box34Check", value: 4);
                context.SetUserValue(triggerID: 9410, key: "Box41Check", value: 3);
                context.SetUserValue(triggerID: 9420, key: "Box42Check", value: 1);
                context.SetUserValue(triggerID: 9430, key: "Box43Check", value: 4);
                context.SetUserValue(triggerID: 9440, key: "Box44Check", value: 2);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP15(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP15 : TriggerState {
            internal StateNumberOffP15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {111}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {125}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {133}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {145}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {212}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {224}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {232}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {245}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {313}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {325}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {331}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {344}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {413}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {421}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {434}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {442}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP15(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP15 : TriggerState {
            internal StateResetP15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 1, key: "G05P15End", value: 1);
                context.SetUserValue(key: "G05P15Set", value: 0);
                context.SetUserValue(key: "G05P15TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP16 : TriggerState {
            internal StateNumberOnP16(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new int[] {115}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {123}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {131}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {145}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {214}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {222}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {231}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {243}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {315}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {321}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {333}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {345}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {412}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {424}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {432}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {444}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerID: 8110, key: "Barrier11", value: 5);
                context.SetUserValue(triggerID: 8120, key: "Barrier12", value: 3);
                context.SetUserValue(triggerID: 8130, key: "Barrier13", value: 1);
                context.SetUserValue(triggerID: 8140, key: "Barrier14", value: 5);
                context.SetUserValue(triggerID: 8210, key: "Barrier21", value: 4);
                context.SetUserValue(triggerID: 8220, key: "Barrier22", value: 2);
                context.SetUserValue(triggerID: 8230, key: "Barrier23", value: 1);
                context.SetUserValue(triggerID: 8240, key: "Barrier24", value: 3);
                context.SetUserValue(triggerID: 8310, key: "Barrier31", value: 5);
                context.SetUserValue(triggerID: 8320, key: "Barrier32", value: 1);
                context.SetUserValue(triggerID: 8330, key: "Barrier33", value: 3);
                context.SetUserValue(triggerID: 8340, key: "Barrier34", value: 5);
                context.SetUserValue(triggerID: 8410, key: "Barrier41", value: 2);
                context.SetUserValue(triggerID: 8420, key: "Barrier42", value: 4);
                context.SetUserValue(triggerID: 8430, key: "Barrier43", value: 2);
                context.SetUserValue(triggerID: 8440, key: "Barrier44", value: 4);
            }

            public override void Execute() {
                if (context.UserValue(key: "G05P16TimeLimit", value: 1)) {
                    context.State = new StateCheckP16(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP16 : TriggerState {
            internal StateCheckP16(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 9110, key: "Box11Check", value: 5);
                context.SetUserValue(triggerID: 9120, key: "Box12Check", value: 3);
                context.SetUserValue(triggerID: 9130, key: "Box13Check", value: 1);
                context.SetUserValue(triggerID: 9140, key: "Box14Check", value: 5);
                context.SetUserValue(triggerID: 9210, key: "Box21Check", value: 4);
                context.SetUserValue(triggerID: 9220, key: "Box22Check", value: 2);
                context.SetUserValue(triggerID: 9230, key: "Box23Check", value: 1);
                context.SetUserValue(triggerID: 9240, key: "Box24Check", value: 3);
                context.SetUserValue(triggerID: 9310, key: "Box31Check", value: 5);
                context.SetUserValue(triggerID: 9320, key: "Box32Check", value: 1);
                context.SetUserValue(triggerID: 9330, key: "Box33Check", value: 3);
                context.SetUserValue(triggerID: 9340, key: "Box34Check", value: 5);
                context.SetUserValue(triggerID: 9410, key: "Box41Check", value: 2);
                context.SetUserValue(triggerID: 9420, key: "Box42Check", value: 4);
                context.SetUserValue(triggerID: 9430, key: "Box43Check", value: 2);
                context.SetUserValue(triggerID: 9440, key: "Box44Check", value: 4);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP16(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP16 : TriggerState {
            internal StateNumberOffP16(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {115}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {123}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {131}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {145}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {214}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {222}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {231}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {243}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {315}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {321}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {333}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {345}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {412}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {424}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {432}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {444}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP16(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP16 : TriggerState {
            internal StateResetP16(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 1, key: "G05P16End", value: 1);
                context.SetUserValue(key: "G05P16Set", value: 0);
                context.SetUserValue(key: "G05P16TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP17 : TriggerState {
            internal StateNumberOnP17(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new int[] {113}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {125}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {135}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {141}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {215}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {225}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {233}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {245}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {315}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {321}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {335}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {343}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {411}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {425}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {435}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {445}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerID: 8110, key: "Barrier11", value: 3);
                context.SetUserValue(triggerID: 8120, key: "Barrier12", value: 5);
                context.SetUserValue(triggerID: 8130, key: "Barrier13", value: 5);
                context.SetUserValue(triggerID: 8140, key: "Barrier14", value: 1);
                context.SetUserValue(triggerID: 8210, key: "Barrier21", value: 5);
                context.SetUserValue(triggerID: 8220, key: "Barrier22", value: 5);
                context.SetUserValue(triggerID: 8230, key: "Barrier23", value: 3);
                context.SetUserValue(triggerID: 8240, key: "Barrier24", value: 5);
                context.SetUserValue(triggerID: 8310, key: "Barrier31", value: 5);
                context.SetUserValue(triggerID: 8320, key: "Barrier32", value: 1);
                context.SetUserValue(triggerID: 8330, key: "Barrier33", value: 5);
                context.SetUserValue(triggerID: 8340, key: "Barrier34", value: 3);
                context.SetUserValue(triggerID: 8410, key: "Barrier41", value: 1);
                context.SetUserValue(triggerID: 8420, key: "Barrier42", value: 5);
                context.SetUserValue(triggerID: 8430, key: "Barrier43", value: 5);
                context.SetUserValue(triggerID: 8440, key: "Barrier44", value: 5);
            }

            public override void Execute() {
                if (context.UserValue(key: "G05P17TimeLimit", value: 1)) {
                    context.State = new StateCheckP17(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP17 : TriggerState {
            internal StateCheckP17(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 9110, key: "Box11Check", value: 3);
                context.SetUserValue(triggerID: 9120, key: "Box12Check", value: 5);
                context.SetUserValue(triggerID: 9130, key: "Box13Check", value: 5);
                context.SetUserValue(triggerID: 9140, key: "Box14Check", value: 1);
                context.SetUserValue(triggerID: 9210, key: "Box21Check", value: 5);
                context.SetUserValue(triggerID: 9220, key: "Box22Check", value: 5);
                context.SetUserValue(triggerID: 9230, key: "Box23Check", value: 3);
                context.SetUserValue(triggerID: 9240, key: "Box24Check", value: 5);
                context.SetUserValue(triggerID: 9310, key: "Box31Check", value: 5);
                context.SetUserValue(triggerID: 9320, key: "Box32Check", value: 1);
                context.SetUserValue(triggerID: 9330, key: "Box33Check", value: 5);
                context.SetUserValue(triggerID: 9340, key: "Box34Check", value: 3);
                context.SetUserValue(triggerID: 9410, key: "Box41Check", value: 1);
                context.SetUserValue(triggerID: 9420, key: "Box42Check", value: 5);
                context.SetUserValue(triggerID: 9430, key: "Box43Check", value: 5);
                context.SetUserValue(triggerID: 9440, key: "Box44Check", value: 5);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP17(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP17 : TriggerState {
            internal StateNumberOffP17(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {113}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {125}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {135}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {141}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {215}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {225}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {233}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {245}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {315}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {321}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {335}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {343}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {411}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {425}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {435}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {445}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP17(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP17 : TriggerState {
            internal StateResetP17(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 1, key: "G05P17End", value: 1);
                context.SetUserValue(key: "G05P17Set", value: 0);
                context.SetUserValue(key: "G05P17TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP18 : TriggerState {
            internal StateNumberOnP18(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new int[] {114}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {121}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {134}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {144}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {212}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {224}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {234}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {242}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {314}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {324}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {331}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {344}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {412}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {424}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {434}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {444}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerID: 8110, key: "Barrier11", value: 4);
                context.SetUserValue(triggerID: 8120, key: "Barrier12", value: 1);
                context.SetUserValue(triggerID: 8130, key: "Barrier13", value: 4);
                context.SetUserValue(triggerID: 8140, key: "Barrier14", value: 4);
                context.SetUserValue(triggerID: 8210, key: "Barrier21", value: 2);
                context.SetUserValue(triggerID: 8220, key: "Barrier22", value: 4);
                context.SetUserValue(triggerID: 8230, key: "Barrier23", value: 4);
                context.SetUserValue(triggerID: 8240, key: "Barrier24", value: 2);
                context.SetUserValue(triggerID: 8310, key: "Barrier31", value: 4);
                context.SetUserValue(triggerID: 8320, key: "Barrier32", value: 4);
                context.SetUserValue(triggerID: 8330, key: "Barrier33", value: 1);
                context.SetUserValue(triggerID: 8340, key: "Barrier34", value: 4);
                context.SetUserValue(triggerID: 8410, key: "Barrier41", value: 2);
                context.SetUserValue(triggerID: 8420, key: "Barrier42", value: 4);
                context.SetUserValue(triggerID: 8430, key: "Barrier43", value: 4);
                context.SetUserValue(triggerID: 8440, key: "Barrier44", value: 4);
            }

            public override void Execute() {
                if (context.UserValue(key: "G05P18TimeLimit", value: 1)) {
                    context.State = new StateCheckP18(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP18 : TriggerState {
            internal StateCheckP18(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 9110, key: "Box11Check", value: 4);
                context.SetUserValue(triggerID: 9120, key: "Box12Check", value: 1);
                context.SetUserValue(triggerID: 9130, key: "Box13Check", value: 4);
                context.SetUserValue(triggerID: 9140, key: "Box14Check", value: 4);
                context.SetUserValue(triggerID: 9210, key: "Box21Check", value: 2);
                context.SetUserValue(triggerID: 9220, key: "Box22Check", value: 4);
                context.SetUserValue(triggerID: 9230, key: "Box23Check", value: 4);
                context.SetUserValue(triggerID: 9240, key: "Box24Check", value: 2);
                context.SetUserValue(triggerID: 9310, key: "Box31Check", value: 4);
                context.SetUserValue(triggerID: 9320, key: "Box32Check", value: 4);
                context.SetUserValue(triggerID: 9330, key: "Box33Check", value: 1);
                context.SetUserValue(triggerID: 9340, key: "Box34Check", value: 4);
                context.SetUserValue(triggerID: 9410, key: "Box41Check", value: 2);
                context.SetUserValue(triggerID: 9420, key: "Box42Check", value: 4);
                context.SetUserValue(triggerID: 9430, key: "Box43Check", value: 4);
                context.SetUserValue(triggerID: 9440, key: "Box44Check", value: 4);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP18(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP18 : TriggerState {
            internal StateNumberOffP18(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {114}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {121}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {134}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {144}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {212}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {224}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {234}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {242}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {314}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {324}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {331}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {344}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {412}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {424}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {434}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {444}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP18(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP18 : TriggerState {
            internal StateResetP18(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 1, key: "G05P18End", value: 1);
                context.SetUserValue(key: "G05P18Set", value: 0);
                context.SetUserValue(key: "G05P18TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP19 : TriggerState {
            internal StateNumberOnP19(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new int[] {111}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {123}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {134}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {143}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {213}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {225}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {233}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {243}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {314}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {323}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {335}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {343}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {413}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {423}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {431}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {443}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerID: 8110, key: "Barrier11", value: 1);
                context.SetUserValue(triggerID: 8120, key: "Barrier12", value: 3);
                context.SetUserValue(triggerID: 8130, key: "Barrier13", value: 4);
                context.SetUserValue(triggerID: 8140, key: "Barrier14", value: 3);
                context.SetUserValue(triggerID: 8210, key: "Barrier21", value: 3);
                context.SetUserValue(triggerID: 8220, key: "Barrier22", value: 5);
                context.SetUserValue(triggerID: 8230, key: "Barrier23", value: 3);
                context.SetUserValue(triggerID: 8240, key: "Barrier24", value: 3);
                context.SetUserValue(triggerID: 8310, key: "Barrier31", value: 4);
                context.SetUserValue(triggerID: 8320, key: "Barrier32", value: 3);
                context.SetUserValue(triggerID: 8330, key: "Barrier33", value: 5);
                context.SetUserValue(triggerID: 8340, key: "Barrier34", value: 3);
                context.SetUserValue(triggerID: 8410, key: "Barrier41", value: 3);
                context.SetUserValue(triggerID: 8420, key: "Barrier42", value: 3);
                context.SetUserValue(triggerID: 8430, key: "Barrier43", value: 1);
                context.SetUserValue(triggerID: 8440, key: "Barrier44", value: 3);
            }

            public override void Execute() {
                if (context.UserValue(key: "G05P19TimeLimit", value: 1)) {
                    context.State = new StateCheckP19(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP19 : TriggerState {
            internal StateCheckP19(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 9110, key: "Box11Check", value: 1);
                context.SetUserValue(triggerID: 9120, key: "Box12Check", value: 3);
                context.SetUserValue(triggerID: 9130, key: "Box13Check", value: 4);
                context.SetUserValue(triggerID: 9140, key: "Box14Check", value: 3);
                context.SetUserValue(triggerID: 9210, key: "Box21Check", value: 3);
                context.SetUserValue(triggerID: 9220, key: "Box22Check", value: 5);
                context.SetUserValue(triggerID: 9230, key: "Box23Check", value: 3);
                context.SetUserValue(triggerID: 9240, key: "Box24Check", value: 3);
                context.SetUserValue(triggerID: 9310, key: "Box31Check", value: 4);
                context.SetUserValue(triggerID: 9320, key: "Box32Check", value: 3);
                context.SetUserValue(triggerID: 9330, key: "Box33Check", value: 5);
                context.SetUserValue(triggerID: 9340, key: "Box34Check", value: 3);
                context.SetUserValue(triggerID: 9410, key: "Box41Check", value: 3);
                context.SetUserValue(triggerID: 9420, key: "Box42Check", value: 3);
                context.SetUserValue(triggerID: 9430, key: "Box43Check", value: 1);
                context.SetUserValue(triggerID: 9440, key: "Box44Check", value: 3);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP19(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP19 : TriggerState {
            internal StateNumberOffP19(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {111}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {123}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {134}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {143}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {213}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {225}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {233}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {243}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {314}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {323}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {335}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {343}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {413}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {423}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {431}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {443}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP19(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP19 : TriggerState {
            internal StateResetP19(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 1, key: "G05P19End", value: 1);
                context.SetUserValue(key: "G05P19Set", value: 0);
                context.SetUserValue(key: "G05P19TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP20 : TriggerState {
            internal StateNumberOnP20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new int[] {113}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {121}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {133}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {144}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {215}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {223}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {233}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {241}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {313}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {323}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {335}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {343}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {413}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {423}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {433}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {444}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerID: 8110, key: "Barrier11", value: 3);
                context.SetUserValue(triggerID: 8120, key: "Barrier12", value: 1);
                context.SetUserValue(triggerID: 8130, key: "Barrier13", value: 3);
                context.SetUserValue(triggerID: 8140, key: "Barrier14", value: 4);
                context.SetUserValue(triggerID: 8210, key: "Barrier21", value: 5);
                context.SetUserValue(triggerID: 8220, key: "Barrier22", value: 3);
                context.SetUserValue(triggerID: 8230, key: "Barrier23", value: 3);
                context.SetUserValue(triggerID: 8240, key: "Barrier24", value: 1);
                context.SetUserValue(triggerID: 8310, key: "Barrier31", value: 3);
                context.SetUserValue(triggerID: 8320, key: "Barrier32", value: 3);
                context.SetUserValue(triggerID: 8330, key: "Barrier33", value: 5);
                context.SetUserValue(triggerID: 8340, key: "Barrier34", value: 3);
                context.SetUserValue(triggerID: 8410, key: "Barrier41", value: 3);
                context.SetUserValue(triggerID: 8420, key: "Barrier42", value: 3);
                context.SetUserValue(triggerID: 8430, key: "Barrier43", value: 3);
                context.SetUserValue(triggerID: 8440, key: "Barrier44", value: 4);
            }

            public override void Execute() {
                if (context.UserValue(key: "G05P20TimeLimit", value: 1)) {
                    context.State = new StateCheckP20(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP20 : TriggerState {
            internal StateCheckP20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 9110, key: "Box11Check", value: 3);
                context.SetUserValue(triggerID: 9120, key: "Box12Check", value: 1);
                context.SetUserValue(triggerID: 9130, key: "Box13Check", value: 3);
                context.SetUserValue(triggerID: 9140, key: "Box14Check", value: 4);
                context.SetUserValue(triggerID: 9210, key: "Box21Check", value: 5);
                context.SetUserValue(triggerID: 9220, key: "Box22Check", value: 3);
                context.SetUserValue(triggerID: 9230, key: "Box23Check", value: 3);
                context.SetUserValue(triggerID: 9240, key: "Box24Check", value: 1);
                context.SetUserValue(triggerID: 9310, key: "Box31Check", value: 3);
                context.SetUserValue(triggerID: 9320, key: "Box32Check", value: 3);
                context.SetUserValue(triggerID: 9330, key: "Box33Check", value: 5);
                context.SetUserValue(triggerID: 9340, key: "Box34Check", value: 3);
                context.SetUserValue(triggerID: 9410, key: "Box41Check", value: 3);
                context.SetUserValue(triggerID: 9420, key: "Box42Check", value: 3);
                context.SetUserValue(triggerID: 9430, key: "Box43Check", value: 3);
                context.SetUserValue(triggerID: 9440, key: "Box44Check", value: 4);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP20(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP20 : TriggerState {
            internal StateNumberOffP20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {113}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {121}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {133}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {144}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {215}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {223}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {233}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {241}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {313}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {323}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {335}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {343}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {413}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {423}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {433}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {444}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP20(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP20 : TriggerState {
            internal StateResetP20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 1, key: "G05P20End", value: 1);
                context.SetUserValue(key: "G05P20Set", value: 0);
                context.SetUserValue(key: "G05P20TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP21 : TriggerState {
            internal StateNumberOnP21(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new int[] {114}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {122}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {134}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {141}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {214}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {224}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {234}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {242}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {312}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {324}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {334}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {344}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {411}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {424}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {432}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {444}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerID: 8110, key: "Barrier11", value: 4);
                context.SetUserValue(triggerID: 8120, key: "Barrier12", value: 2);
                context.SetUserValue(triggerID: 8130, key: "Barrier13", value: 4);
                context.SetUserValue(triggerID: 8140, key: "Barrier14", value: 1);
                context.SetUserValue(triggerID: 8210, key: "Barrier21", value: 4);
                context.SetUserValue(triggerID: 8220, key: "Barrier22", value: 4);
                context.SetUserValue(triggerID: 8230, key: "Barrier23", value: 4);
                context.SetUserValue(triggerID: 8240, key: "Barrier24", value: 2);
                context.SetUserValue(triggerID: 8310, key: "Barrier31", value: 2);
                context.SetUserValue(triggerID: 8320, key: "Barrier32", value: 4);
                context.SetUserValue(triggerID: 8330, key: "Barrier33", value: 4);
                context.SetUserValue(triggerID: 8340, key: "Barrier34", value: 4);
                context.SetUserValue(triggerID: 8410, key: "Barrier41", value: 1);
                context.SetUserValue(triggerID: 8420, key: "Barrier42", value: 4);
                context.SetUserValue(triggerID: 8430, key: "Barrier43", value: 2);
                context.SetUserValue(triggerID: 8440, key: "Barrier44", value: 4);
            }

            public override void Execute() {
                if (context.UserValue(key: "G05P21TimeLimit", value: 1)) {
                    context.State = new StateCheckP21(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP21 : TriggerState {
            internal StateCheckP21(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 9110, key: "Box11Check", value: 4);
                context.SetUserValue(triggerID: 9120, key: "Box12Check", value: 2);
                context.SetUserValue(triggerID: 9130, key: "Box13Check", value: 4);
                context.SetUserValue(triggerID: 9140, key: "Box14Check", value: 1);
                context.SetUserValue(triggerID: 9210, key: "Box21Check", value: 4);
                context.SetUserValue(triggerID: 9220, key: "Box22Check", value: 4);
                context.SetUserValue(triggerID: 9230, key: "Box23Check", value: 4);
                context.SetUserValue(triggerID: 9240, key: "Box24Check", value: 2);
                context.SetUserValue(triggerID: 9310, key: "Box31Check", value: 2);
                context.SetUserValue(triggerID: 9320, key: "Box32Check", value: 4);
                context.SetUserValue(triggerID: 9330, key: "Box33Check", value: 4);
                context.SetUserValue(triggerID: 9340, key: "Box34Check", value: 4);
                context.SetUserValue(triggerID: 9410, key: "Box41Check", value: 1);
                context.SetUserValue(triggerID: 9420, key: "Box42Check", value: 4);
                context.SetUserValue(triggerID: 9430, key: "Box43Check", value: 2);
                context.SetUserValue(triggerID: 9440, key: "Box44Check", value: 4);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP21(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP21 : TriggerState {
            internal StateNumberOffP21(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {114}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {122}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {134}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {141}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {214}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {224}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {234}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {242}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {312}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {324}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {334}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {344}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {411}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {424}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {432}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {444}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP21(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP21 : TriggerState {
            internal StateResetP21(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 1, key: "G05P21End", value: 1);
                context.SetUserValue(key: "G05P21Set", value: 0);
                context.SetUserValue(key: "G05P21TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP22 : TriggerState {
            internal StateNumberOnP22(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new int[] {112}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {124}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {131}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {144}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {214}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {222}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {234}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {244}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {311}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {324}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {332}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {344}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {414}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {424}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {434}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {442}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerID: 8110, key: "Barrier11", value: 2);
                context.SetUserValue(triggerID: 8120, key: "Barrier12", value: 4);
                context.SetUserValue(triggerID: 8130, key: "Barrier13", value: 1);
                context.SetUserValue(triggerID: 8140, key: "Barrier14", value: 4);
                context.SetUserValue(triggerID: 8210, key: "Barrier21", value: 4);
                context.SetUserValue(triggerID: 8220, key: "Barrier22", value: 2);
                context.SetUserValue(triggerID: 8230, key: "Barrier23", value: 4);
                context.SetUserValue(triggerID: 8240, key: "Barrier24", value: 4);
                context.SetUserValue(triggerID: 8310, key: "Barrier31", value: 1);
                context.SetUserValue(triggerID: 8320, key: "Barrier32", value: 4);
                context.SetUserValue(triggerID: 8330, key: "Barrier33", value: 2);
                context.SetUserValue(triggerID: 8340, key: "Barrier34", value: 4);
                context.SetUserValue(triggerID: 8410, key: "Barrier41", value: 4);
                context.SetUserValue(triggerID: 8420, key: "Barrier42", value: 4);
                context.SetUserValue(triggerID: 8430, key: "Barrier43", value: 4);
                context.SetUserValue(triggerID: 8440, key: "Barrier44", value: 2);
            }

            public override void Execute() {
                if (context.UserValue(key: "G05P22TimeLimit", value: 1)) {
                    context.State = new StateCheckP22(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP22 : TriggerState {
            internal StateCheckP22(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 9110, key: "Box11Check", value: 2);
                context.SetUserValue(triggerID: 9120, key: "Box12Check", value: 4);
                context.SetUserValue(triggerID: 9130, key: "Box13Check", value: 1);
                context.SetUserValue(triggerID: 9140, key: "Box14Check", value: 4);
                context.SetUserValue(triggerID: 9210, key: "Box21Check", value: 4);
                context.SetUserValue(triggerID: 9220, key: "Box22Check", value: 2);
                context.SetUserValue(triggerID: 9230, key: "Box23Check", value: 4);
                context.SetUserValue(triggerID: 9240, key: "Box24Check", value: 4);
                context.SetUserValue(triggerID: 9310, key: "Box31Check", value: 1);
                context.SetUserValue(triggerID: 9320, key: "Box32Check", value: 4);
                context.SetUserValue(triggerID: 9330, key: "Box33Check", value: 2);
                context.SetUserValue(triggerID: 9340, key: "Box34Check", value: 4);
                context.SetUserValue(triggerID: 9410, key: "Box41Check", value: 4);
                context.SetUserValue(triggerID: 9420, key: "Box42Check", value: 4);
                context.SetUserValue(triggerID: 9430, key: "Box43Check", value: 4);
                context.SetUserValue(triggerID: 9440, key: "Box44Check", value: 2);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP22(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP22 : TriggerState {
            internal StateNumberOffP22(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {112}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {124}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {131}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {144}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {214}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {222}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {234}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {244}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {311}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {324}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {332}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {344}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {414}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {424}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {434}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {442}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP22(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP22 : TriggerState {
            internal StateResetP22(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 1, key: "G05P22End", value: 1);
                context.SetUserValue(key: "G05P22Set", value: 0);
                context.SetUserValue(key: "G05P22TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP23 : TriggerState {
            internal StateNumberOnP23(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new int[] {113}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {124}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {135}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {143}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {215}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {221}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {234}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {244}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {313}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {324}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {333}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {345}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {414}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {425}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {431}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {443}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerID: 8110, key: "Barrier11", value: 3);
                context.SetUserValue(triggerID: 8120, key: "Barrier12", value: 4);
                context.SetUserValue(triggerID: 8130, key: "Barrier13", value: 5);
                context.SetUserValue(triggerID: 8140, key: "Barrier14", value: 3);
                context.SetUserValue(triggerID: 8210, key: "Barrier21", value: 5);
                context.SetUserValue(triggerID: 8220, key: "Barrier22", value: 1);
                context.SetUserValue(triggerID: 8230, key: "Barrier23", value: 4);
                context.SetUserValue(triggerID: 8240, key: "Barrier24", value: 4);
                context.SetUserValue(triggerID: 8310, key: "Barrier31", value: 3);
                context.SetUserValue(triggerID: 8320, key: "Barrier32", value: 4);
                context.SetUserValue(triggerID: 8330, key: "Barrier33", value: 3);
                context.SetUserValue(triggerID: 8340, key: "Barrier34", value: 5);
                context.SetUserValue(triggerID: 8410, key: "Barrier41", value: 4);
                context.SetUserValue(triggerID: 8420, key: "Barrier42", value: 5);
                context.SetUserValue(triggerID: 8430, key: "Barrier43", value: 1);
                context.SetUserValue(triggerID: 8440, key: "Barrier44", value: 3);
            }

            public override void Execute() {
                if (context.UserValue(key: "G05P23TimeLimit", value: 1)) {
                    context.State = new StateCheckP23(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP23 : TriggerState {
            internal StateCheckP23(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 9110, key: "Box11Check", value: 3);
                context.SetUserValue(triggerID: 9120, key: "Box12Check", value: 4);
                context.SetUserValue(triggerID: 9130, key: "Box13Check", value: 5);
                context.SetUserValue(triggerID: 9140, key: "Box14Check", value: 3);
                context.SetUserValue(triggerID: 9210, key: "Box21Check", value: 5);
                context.SetUserValue(triggerID: 9220, key: "Box22Check", value: 1);
                context.SetUserValue(triggerID: 9230, key: "Box23Check", value: 4);
                context.SetUserValue(triggerID: 9240, key: "Box24Check", value: 4);
                context.SetUserValue(triggerID: 9310, key: "Box31Check", value: 3);
                context.SetUserValue(triggerID: 9320, key: "Box32Check", value: 4);
                context.SetUserValue(triggerID: 9330, key: "Box33Check", value: 3);
                context.SetUserValue(triggerID: 9340, key: "Box34Check", value: 5);
                context.SetUserValue(triggerID: 9410, key: "Box41Check", value: 4);
                context.SetUserValue(triggerID: 9420, key: "Box42Check", value: 5);
                context.SetUserValue(triggerID: 9430, key: "Box43Check", value: 1);
                context.SetUserValue(triggerID: 9440, key: "Box44Check", value: 3);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP23(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP23 : TriggerState {
            internal StateNumberOffP23(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {113}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {124}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {135}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {143}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {215}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {221}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {234}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {244}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {313}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {324}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {333}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {345}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {414}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {425}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {431}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {443}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP23(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP23 : TriggerState {
            internal StateResetP23(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 1, key: "G05P23End", value: 1);
                context.SetUserValue(key: "G05P23Set", value: 0);
                context.SetUserValue(key: "G05P23TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP24 : TriggerState {
            internal StateNumberOnP24(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new int[] {114}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {124}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {133}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {141}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {213}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {223}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {234}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {244}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {314}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {321}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {334}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {343}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {413}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {423}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {434}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {444}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerID: 8110, key: "Barrier11", value: 4);
                context.SetUserValue(triggerID: 8120, key: "Barrier12", value: 4);
                context.SetUserValue(triggerID: 8130, key: "Barrier13", value: 3);
                context.SetUserValue(triggerID: 8140, key: "Barrier14", value: 1);
                context.SetUserValue(triggerID: 8210, key: "Barrier21", value: 3);
                context.SetUserValue(triggerID: 8220, key: "Barrier22", value: 3);
                context.SetUserValue(triggerID: 8230, key: "Barrier23", value: 4);
                context.SetUserValue(triggerID: 8240, key: "Barrier24", value: 4);
                context.SetUserValue(triggerID: 8310, key: "Barrier31", value: 4);
                context.SetUserValue(triggerID: 8320, key: "Barrier32", value: 1);
                context.SetUserValue(triggerID: 8330, key: "Barrier33", value: 4);
                context.SetUserValue(triggerID: 8340, key: "Barrier34", value: 3);
                context.SetUserValue(triggerID: 8410, key: "Barrier41", value: 3);
                context.SetUserValue(triggerID: 8420, key: "Barrier42", value: 3);
                context.SetUserValue(triggerID: 8430, key: "Barrier43", value: 4);
                context.SetUserValue(triggerID: 8440, key: "Barrier44", value: 4);
            }

            public override void Execute() {
                if (context.UserValue(key: "G05P24TimeLimit", value: 1)) {
                    context.State = new StateCheckP24(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP24 : TriggerState {
            internal StateCheckP24(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 9110, key: "Box11Check", value: 4);
                context.SetUserValue(triggerID: 9120, key: "Box12Check", value: 4);
                context.SetUserValue(triggerID: 9130, key: "Box13Check", value: 3);
                context.SetUserValue(triggerID: 9140, key: "Box14Check", value: 1);
                context.SetUserValue(triggerID: 9210, key: "Box21Check", value: 3);
                context.SetUserValue(triggerID: 9220, key: "Box22Check", value: 3);
                context.SetUserValue(triggerID: 9230, key: "Box23Check", value: 4);
                context.SetUserValue(triggerID: 9240, key: "Box24Check", value: 4);
                context.SetUserValue(triggerID: 9310, key: "Box31Check", value: 4);
                context.SetUserValue(triggerID: 9320, key: "Box32Check", value: 1);
                context.SetUserValue(triggerID: 9330, key: "Box33Check", value: 4);
                context.SetUserValue(triggerID: 9340, key: "Box34Check", value: 3);
                context.SetUserValue(triggerID: 9410, key: "Box41Check", value: 3);
                context.SetUserValue(triggerID: 9420, key: "Box42Check", value: 3);
                context.SetUserValue(triggerID: 9430, key: "Box43Check", value: 4);
                context.SetUserValue(triggerID: 9440, key: "Box44Check", value: 4);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP24(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP24 : TriggerState {
            internal StateNumberOffP24(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {114}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {124}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {133}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {141}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {213}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {223}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {234}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {244}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {314}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {321}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {334}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {343}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {413}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {423}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {434}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {444}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP24(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP24 : TriggerState {
            internal StateResetP24(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 1, key: "G05P24End", value: 1);
                context.SetUserValue(key: "G05P24Set", value: 0);
                context.SetUserValue(key: "G05P24TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP25 : TriggerState {
            internal StateNumberOnP25(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new int[] {111}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {125}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {134}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {141}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {215}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {224}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {231}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {244}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {315}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {321}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {334}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {345}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {414}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {421}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {435}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {441}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerID: 8110, key: "Barrier11", value: 1);
                context.SetUserValue(triggerID: 8120, key: "Barrier12", value: 5);
                context.SetUserValue(triggerID: 8130, key: "Barrier13", value: 4);
                context.SetUserValue(triggerID: 8140, key: "Barrier14", value: 1);
                context.SetUserValue(triggerID: 8210, key: "Barrier21", value: 5);
                context.SetUserValue(triggerID: 8220, key: "Barrier22", value: 4);
                context.SetUserValue(triggerID: 8230, key: "Barrier23", value: 1);
                context.SetUserValue(triggerID: 8240, key: "Barrier24", value: 4);
                context.SetUserValue(triggerID: 8310, key: "Barrier31", value: 5);
                context.SetUserValue(triggerID: 8320, key: "Barrier32", value: 1);
                context.SetUserValue(triggerID: 8330, key: "Barrier33", value: 4);
                context.SetUserValue(triggerID: 8340, key: "Barrier34", value: 5);
                context.SetUserValue(triggerID: 8410, key: "Barrier41", value: 4);
                context.SetUserValue(triggerID: 8420, key: "Barrier42", value: 1);
                context.SetUserValue(triggerID: 8430, key: "Barrier43", value: 5);
                context.SetUserValue(triggerID: 8440, key: "Barrier44", value: 1);
            }

            public override void Execute() {
                if (context.UserValue(key: "G05P25TimeLimit", value: 1)) {
                    context.State = new StateCheckP25(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP25 : TriggerState {
            internal StateCheckP25(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 9110, key: "Box11Check", value: 1);
                context.SetUserValue(triggerID: 9120, key: "Box12Check", value: 5);
                context.SetUserValue(triggerID: 9130, key: "Box13Check", value: 4);
                context.SetUserValue(triggerID: 9140, key: "Box14Check", value: 1);
                context.SetUserValue(triggerID: 9210, key: "Box21Check", value: 5);
                context.SetUserValue(triggerID: 9220, key: "Box22Check", value: 4);
                context.SetUserValue(triggerID: 9230, key: "Box23Check", value: 1);
                context.SetUserValue(triggerID: 9240, key: "Box24Check", value: 4);
                context.SetUserValue(triggerID: 9310, key: "Box31Check", value: 5);
                context.SetUserValue(triggerID: 9320, key: "Box32Check", value: 1);
                context.SetUserValue(triggerID: 9330, key: "Box33Check", value: 4);
                context.SetUserValue(triggerID: 9340, key: "Box34Check", value: 5);
                context.SetUserValue(triggerID: 9410, key: "Box41Check", value: 4);
                context.SetUserValue(triggerID: 9420, key: "Box42Check", value: 1);
                context.SetUserValue(triggerID: 9430, key: "Box43Check", value: 5);
                context.SetUserValue(triggerID: 9440, key: "Box44Check", value: 1);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP25(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP25 : TriggerState {
            internal StateNumberOffP25(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {111}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {125}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {134}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {141}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {215}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {224}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {231}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {244}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {315}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {321}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {334}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {345}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {414}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {421}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {435}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {441}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP25(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP25 : TriggerState {
            internal StateResetP25(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 1, key: "G05P25End", value: 1);
                context.SetUserValue(key: "G05P25Set", value: 0);
                context.SetUserValue(key: "G05P25TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP26 : TriggerState {
            internal StateNumberOnP26(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new int[] {114}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {125}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {135}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {144}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {213}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {225}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {233}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {245}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {315}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {324}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {334}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {341}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {414}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {425}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {431}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {443}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerID: 8110, key: "Barrier11", value: 4);
                context.SetUserValue(triggerID: 8120, key: "Barrier12", value: 5);
                context.SetUserValue(triggerID: 8130, key: "Barrier13", value: 5);
                context.SetUserValue(triggerID: 8140, key: "Barrier14", value: 4);
                context.SetUserValue(triggerID: 8210, key: "Barrier21", value: 3);
                context.SetUserValue(triggerID: 8220, key: "Barrier22", value: 5);
                context.SetUserValue(triggerID: 8230, key: "Barrier23", value: 3);
                context.SetUserValue(triggerID: 8240, key: "Barrier24", value: 5);
                context.SetUserValue(triggerID: 8310, key: "Barrier31", value: 5);
                context.SetUserValue(triggerID: 8320, key: "Barrier32", value: 4);
                context.SetUserValue(triggerID: 8330, key: "Barrier33", value: 4);
                context.SetUserValue(triggerID: 8340, key: "Barrier34", value: 1);
                context.SetUserValue(triggerID: 8410, key: "Barrier41", value: 4);
                context.SetUserValue(triggerID: 8420, key: "Barrier42", value: 5);
                context.SetUserValue(triggerID: 8430, key: "Barrier43", value: 1);
                context.SetUserValue(triggerID: 8440, key: "Barrier44", value: 3);
            }

            public override void Execute() {
                if (context.UserValue(key: "G05P26TimeLimit", value: 1)) {
                    context.State = new StateCheckP26(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP26 : TriggerState {
            internal StateCheckP26(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 9110, key: "Box11Check", value: 4);
                context.SetUserValue(triggerID: 9120, key: "Box12Check", value: 5);
                context.SetUserValue(triggerID: 9130, key: "Box13Check", value: 5);
                context.SetUserValue(triggerID: 9140, key: "Box14Check", value: 4);
                context.SetUserValue(triggerID: 9210, key: "Box21Check", value: 3);
                context.SetUserValue(triggerID: 9220, key: "Box22Check", value: 5);
                context.SetUserValue(triggerID: 9230, key: "Box23Check", value: 3);
                context.SetUserValue(triggerID: 9240, key: "Box24Check", value: 5);
                context.SetUserValue(triggerID: 9310, key: "Box31Check", value: 5);
                context.SetUserValue(triggerID: 9320, key: "Box32Check", value: 4);
                context.SetUserValue(triggerID: 9330, key: "Box33Check", value: 4);
                context.SetUserValue(triggerID: 9340, key: "Box34Check", value: 1);
                context.SetUserValue(triggerID: 9410, key: "Box41Check", value: 4);
                context.SetUserValue(triggerID: 9420, key: "Box42Check", value: 5);
                context.SetUserValue(triggerID: 9430, key: "Box43Check", value: 1);
                context.SetUserValue(triggerID: 9440, key: "Box44Check", value: 3);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP26(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP26 : TriggerState {
            internal StateNumberOffP26(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {114}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {125}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {135}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {144}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {213}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {225}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {233}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {245}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {315}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {324}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {334}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {341}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {414}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {425}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {431}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {443}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP26(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP26 : TriggerState {
            internal StateResetP26(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 1, key: "G05P26End", value: 1);
                context.SetUserValue(key: "G05P26Set", value: 0);
                context.SetUserValue(key: "G05P26TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP27 : TriggerState {
            internal StateNumberOnP27(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new int[] {114}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {121}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {134}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {145}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {215}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {224}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {235}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {244}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {312}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {325}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {331}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {345}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {415}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {422}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {434}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {442}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerID: 8110, key: "Barrier11", value: 4);
                context.SetUserValue(triggerID: 8120, key: "Barrier12", value: 1);
                context.SetUserValue(triggerID: 8130, key: "Barrier13", value: 4);
                context.SetUserValue(triggerID: 8140, key: "Barrier14", value: 5);
                context.SetUserValue(triggerID: 8210, key: "Barrier21", value: 5);
                context.SetUserValue(triggerID: 8220, key: "Barrier22", value: 4);
                context.SetUserValue(triggerID: 8230, key: "Barrier23", value: 5);
                context.SetUserValue(triggerID: 8240, key: "Barrier24", value: 4);
                context.SetUserValue(triggerID: 8310, key: "Barrier31", value: 2);
                context.SetUserValue(triggerID: 8320, key: "Barrier32", value: 5);
                context.SetUserValue(triggerID: 8330, key: "Barrier33", value: 1);
                context.SetUserValue(triggerID: 8340, key: "Barrier34", value: 5);
                context.SetUserValue(triggerID: 8410, key: "Barrier41", value: 5);
                context.SetUserValue(triggerID: 8420, key: "Barrier42", value: 2);
                context.SetUserValue(triggerID: 8430, key: "Barrier43", value: 4);
                context.SetUserValue(triggerID: 8440, key: "Barrier44", value: 2);
            }

            public override void Execute() {
                if (context.UserValue(key: "G05P27TimeLimit", value: 1)) {
                    context.State = new StateCheckP27(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP27 : TriggerState {
            internal StateCheckP27(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 9110, key: "Box11Check", value: 4);
                context.SetUserValue(triggerID: 9120, key: "Box12Check", value: 1);
                context.SetUserValue(triggerID: 9130, key: "Box13Check", value: 4);
                context.SetUserValue(triggerID: 9140, key: "Box14Check", value: 5);
                context.SetUserValue(triggerID: 9210, key: "Box21Check", value: 5);
                context.SetUserValue(triggerID: 9220, key: "Box22Check", value: 4);
                context.SetUserValue(triggerID: 9230, key: "Box23Check", value: 5);
                context.SetUserValue(triggerID: 9240, key: "Box24Check", value: 4);
                context.SetUserValue(triggerID: 9310, key: "Box31Check", value: 2);
                context.SetUserValue(triggerID: 9320, key: "Box32Check", value: 5);
                context.SetUserValue(triggerID: 9330, key: "Box33Check", value: 1);
                context.SetUserValue(triggerID: 9340, key: "Box34Check", value: 5);
                context.SetUserValue(triggerID: 9410, key: "Box41Check", value: 5);
                context.SetUserValue(triggerID: 9420, key: "Box42Check", value: 2);
                context.SetUserValue(triggerID: 9430, key: "Box43Check", value: 4);
                context.SetUserValue(triggerID: 9440, key: "Box44Check", value: 2);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP27(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP27 : TriggerState {
            internal StateNumberOffP27(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {114}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {121}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {134}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {145}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {215}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {224}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {235}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {244}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {312}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {325}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {331}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {345}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {415}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {422}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {434}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {442}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP27(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP27 : TriggerState {
            internal StateResetP27(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 1, key: "G05P27End", value: 1);
                context.SetUserValue(key: "G05P27Set", value: 0);
                context.SetUserValue(key: "G05P27TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP28 : TriggerState {
            internal StateNumberOnP28(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new int[] {113}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {123}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {131}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {143}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {213}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {225}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {233}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {245}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {313}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {323}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {335}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {343}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {415}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {421}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {433}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {443}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerID: 8110, key: "Barrier11", value: 3);
                context.SetUserValue(triggerID: 8120, key: "Barrier12", value: 3);
                context.SetUserValue(triggerID: 8130, key: "Barrier13", value: 1);
                context.SetUserValue(triggerID: 8140, key: "Barrier14", value: 3);
                context.SetUserValue(triggerID: 8210, key: "Barrier21", value: 3);
                context.SetUserValue(triggerID: 8220, key: "Barrier22", value: 5);
                context.SetUserValue(triggerID: 8230, key: "Barrier23", value: 3);
                context.SetUserValue(triggerID: 8240, key: "Barrier24", value: 5);
                context.SetUserValue(triggerID: 8310, key: "Barrier31", value: 3);
                context.SetUserValue(triggerID: 8320, key: "Barrier32", value: 3);
                context.SetUserValue(triggerID: 8330, key: "Barrier33", value: 5);
                context.SetUserValue(triggerID: 8340, key: "Barrier34", value: 3);
                context.SetUserValue(triggerID: 8410, key: "Barrier41", value: 5);
                context.SetUserValue(triggerID: 8420, key: "Barrier42", value: 1);
                context.SetUserValue(triggerID: 8430, key: "Barrier43", value: 3);
                context.SetUserValue(triggerID: 8440, key: "Barrier44", value: 3);
            }

            public override void Execute() {
                if (context.UserValue(key: "G05P28TimeLimit", value: 1)) {
                    context.State = new StateCheckP28(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP28 : TriggerState {
            internal StateCheckP28(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 9110, key: "Box11Check", value: 3);
                context.SetUserValue(triggerID: 9120, key: "Box12Check", value: 3);
                context.SetUserValue(triggerID: 9130, key: "Box13Check", value: 1);
                context.SetUserValue(triggerID: 9140, key: "Box14Check", value: 3);
                context.SetUserValue(triggerID: 9210, key: "Box21Check", value: 3);
                context.SetUserValue(triggerID: 9220, key: "Box22Check", value: 5);
                context.SetUserValue(triggerID: 9230, key: "Box23Check", value: 3);
                context.SetUserValue(triggerID: 9240, key: "Box24Check", value: 5);
                context.SetUserValue(triggerID: 9310, key: "Box31Check", value: 3);
                context.SetUserValue(triggerID: 9320, key: "Box32Check", value: 3);
                context.SetUserValue(triggerID: 9330, key: "Box33Check", value: 5);
                context.SetUserValue(triggerID: 9340, key: "Box34Check", value: 3);
                context.SetUserValue(triggerID: 9410, key: "Box41Check", value: 5);
                context.SetUserValue(triggerID: 9420, key: "Box42Check", value: 1);
                context.SetUserValue(triggerID: 9430, key: "Box43Check", value: 3);
                context.SetUserValue(triggerID: 9440, key: "Box44Check", value: 3);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP28(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP28 : TriggerState {
            internal StateNumberOffP28(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {113}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {123}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {131}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {143}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {213}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {225}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {233}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {245}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {313}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {323}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {335}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {343}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {415}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {421}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {433}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {443}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP28(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP28 : TriggerState {
            internal StateResetP28(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 1, key: "G05P28End", value: 1);
                context.SetUserValue(key: "G05P28Set", value: 0);
                context.SetUserValue(key: "G05P28TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP29 : TriggerState {
            internal StateNumberOnP29(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new int[] {113}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {123}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {134}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {143}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {214}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {223}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {233}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {242}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {311}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {324}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {333}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {344}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {413}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {423}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {434}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {443}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerID: 8110, key: "Barrier11", value: 3);
                context.SetUserValue(triggerID: 8120, key: "Barrier12", value: 3);
                context.SetUserValue(triggerID: 8130, key: "Barrier13", value: 4);
                context.SetUserValue(triggerID: 8140, key: "Barrier14", value: 3);
                context.SetUserValue(triggerID: 8210, key: "Barrier21", value: 4);
                context.SetUserValue(triggerID: 8220, key: "Barrier22", value: 3);
                context.SetUserValue(triggerID: 8230, key: "Barrier23", value: 3);
                context.SetUserValue(triggerID: 8240, key: "Barrier24", value: 2);
                context.SetUserValue(triggerID: 8310, key: "Barrier31", value: 1);
                context.SetUserValue(triggerID: 8320, key: "Barrier32", value: 4);
                context.SetUserValue(triggerID: 8330, key: "Barrier33", value: 3);
                context.SetUserValue(triggerID: 8340, key: "Barrier34", value: 4);
                context.SetUserValue(triggerID: 8410, key: "Barrier41", value: 3);
                context.SetUserValue(triggerID: 8420, key: "Barrier42", value: 3);
                context.SetUserValue(triggerID: 8430, key: "Barrier43", value: 4);
                context.SetUserValue(triggerID: 8440, key: "Barrier44", value: 3);
            }

            public override void Execute() {
                if (context.UserValue(key: "G05P29TimeLimit", value: 1)) {
                    context.State = new StateCheckP29(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP29 : TriggerState {
            internal StateCheckP29(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 9110, key: "Box11Check", value: 3);
                context.SetUserValue(triggerID: 9120, key: "Box12Check", value: 3);
                context.SetUserValue(triggerID: 9130, key: "Box13Check", value: 4);
                context.SetUserValue(triggerID: 9140, key: "Box14Check", value: 3);
                context.SetUserValue(triggerID: 9210, key: "Box21Check", value: 4);
                context.SetUserValue(triggerID: 9220, key: "Box22Check", value: 3);
                context.SetUserValue(triggerID: 9230, key: "Box23Check", value: 3);
                context.SetUserValue(triggerID: 9240, key: "Box24Check", value: 2);
                context.SetUserValue(triggerID: 9310, key: "Box31Check", value: 1);
                context.SetUserValue(triggerID: 9320, key: "Box32Check", value: 4);
                context.SetUserValue(triggerID: 9330, key: "Box33Check", value: 3);
                context.SetUserValue(triggerID: 9340, key: "Box34Check", value: 4);
                context.SetUserValue(triggerID: 9410, key: "Box41Check", value: 3);
                context.SetUserValue(triggerID: 9420, key: "Box42Check", value: 3);
                context.SetUserValue(triggerID: 9430, key: "Box43Check", value: 4);
                context.SetUserValue(triggerID: 9440, key: "Box44Check", value: 3);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP29(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP29 : TriggerState {
            internal StateNumberOffP29(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {113}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {123}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {134}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {143}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {214}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {223}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {233}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {242}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {311}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {324}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {333}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {344}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {413}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {423}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {434}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {443}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP29(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP29 : TriggerState {
            internal StateResetP29(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 1, key: "G05P29End", value: 1);
                context.SetUserValue(key: "G05P29Set", value: 0);
                context.SetUserValue(key: "G05P29TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP30 : TriggerState {
            internal StateNumberOnP30(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new int[] {112}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {125}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {135}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {142}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {213}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {222}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {232}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {245}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {315}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {322}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {332}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {341}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {412}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {425}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {435}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {442}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerID: 8110, key: "Barrier11", value: 2);
                context.SetUserValue(triggerID: 8120, key: "Barrier12", value: 5);
                context.SetUserValue(triggerID: 8130, key: "Barrier13", value: 5);
                context.SetUserValue(triggerID: 8140, key: "Barrier14", value: 2);
                context.SetUserValue(triggerID: 8210, key: "Barrier21", value: 3);
                context.SetUserValue(triggerID: 8220, key: "Barrier22", value: 2);
                context.SetUserValue(triggerID: 8230, key: "Barrier23", value: 2);
                context.SetUserValue(triggerID: 8240, key: "Barrier24", value: 5);
                context.SetUserValue(triggerID: 8310, key: "Barrier31", value: 5);
                context.SetUserValue(triggerID: 8320, key: "Barrier32", value: 2);
                context.SetUserValue(triggerID: 8330, key: "Barrier33", value: 2);
                context.SetUserValue(triggerID: 8340, key: "Barrier34", value: 1);
                context.SetUserValue(triggerID: 8410, key: "Barrier41", value: 2);
                context.SetUserValue(triggerID: 8420, key: "Barrier42", value: 5);
                context.SetUserValue(triggerID: 8430, key: "Barrier43", value: 5);
                context.SetUserValue(triggerID: 8440, key: "Barrier44", value: 2);
            }

            public override void Execute() {
                if (context.UserValue(key: "G05P30TimeLimit", value: 1)) {
                    context.State = new StateCheckP30(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP30 : TriggerState {
            internal StateCheckP30(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 9110, key: "Box11Check", value: 2);
                context.SetUserValue(triggerID: 9120, key: "Box12Check", value: 5);
                context.SetUserValue(triggerID: 9130, key: "Box13Check", value: 5);
                context.SetUserValue(triggerID: 9140, key: "Box14Check", value: 2);
                context.SetUserValue(triggerID: 9210, key: "Box21Check", value: 3);
                context.SetUserValue(triggerID: 9220, key: "Box22Check", value: 2);
                context.SetUserValue(triggerID: 9230, key: "Box23Check", value: 2);
                context.SetUserValue(triggerID: 9240, key: "Box24Check", value: 5);
                context.SetUserValue(triggerID: 9310, key: "Box31Check", value: 5);
                context.SetUserValue(triggerID: 9320, key: "Box32Check", value: 2);
                context.SetUserValue(triggerID: 9330, key: "Box33Check", value: 2);
                context.SetUserValue(triggerID: 9340, key: "Box34Check", value: 1);
                context.SetUserValue(triggerID: 9410, key: "Box41Check", value: 2);
                context.SetUserValue(triggerID: 9420, key: "Box42Check", value: 5);
                context.SetUserValue(triggerID: 9430, key: "Box43Check", value: 5);
                context.SetUserValue(triggerID: 9440, key: "Box44Check", value: 2);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP30(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP30 : TriggerState {
            internal StateNumberOffP30(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {112}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {125}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {135}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {142}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {213}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {222}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {232}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {245}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {315}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {322}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {332}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {341}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {412}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {425}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {435}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {442}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP30(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP30 : TriggerState {
            internal StateResetP30(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 1, key: "G05P30End", value: 1);
                context.SetUserValue(key: "G05P30Set", value: 0);
                context.SetUserValue(key: "G05P30TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP31 : TriggerState {
            internal StateNumberOnP31(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new int[] {113}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {125}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {132}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {144}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {215}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {221}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {234}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {245}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {315}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {324}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {335}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {342}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {413}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {424}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {431}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {443}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerID: 8110, key: "Barrier11", value: 3);
                context.SetUserValue(triggerID: 8120, key: "Barrier12", value: 5);
                context.SetUserValue(triggerID: 8130, key: "Barrier13", value: 2);
                context.SetUserValue(triggerID: 8140, key: "Barrier14", value: 4);
                context.SetUserValue(triggerID: 8210, key: "Barrier21", value: 5);
                context.SetUserValue(triggerID: 8220, key: "Barrier22", value: 1);
                context.SetUserValue(triggerID: 8230, key: "Barrier23", value: 4);
                context.SetUserValue(triggerID: 8240, key: "Barrier24", value: 5);
                context.SetUserValue(triggerID: 8310, key: "Barrier31", value: 5);
                context.SetUserValue(triggerID: 8320, key: "Barrier32", value: 4);
                context.SetUserValue(triggerID: 8330, key: "Barrier33", value: 5);
                context.SetUserValue(triggerID: 8340, key: "Barrier34", value: 2);
                context.SetUserValue(triggerID: 8410, key: "Barrier41", value: 3);
                context.SetUserValue(triggerID: 8420, key: "Barrier42", value: 4);
                context.SetUserValue(triggerID: 8430, key: "Barrier43", value: 1);
                context.SetUserValue(triggerID: 8440, key: "Barrier44", value: 3);
            }

            public override void Execute() {
                if (context.UserValue(key: "G05P31TimeLimit", value: 1)) {
                    context.State = new StateCheckP31(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP31 : TriggerState {
            internal StateCheckP31(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 9110, key: "Box11Check", value: 3);
                context.SetUserValue(triggerID: 9120, key: "Box12Check", value: 5);
                context.SetUserValue(triggerID: 9130, key: "Box13Check", value: 2);
                context.SetUserValue(triggerID: 9140, key: "Box14Check", value: 4);
                context.SetUserValue(triggerID: 9210, key: "Box21Check", value: 5);
                context.SetUserValue(triggerID: 9220, key: "Box22Check", value: 1);
                context.SetUserValue(triggerID: 9230, key: "Box23Check", value: 4);
                context.SetUserValue(triggerID: 9240, key: "Box24Check", value: 5);
                context.SetUserValue(triggerID: 9310, key: "Box31Check", value: 5);
                context.SetUserValue(triggerID: 9320, key: "Box32Check", value: 4);
                context.SetUserValue(triggerID: 9330, key: "Box33Check", value: 5);
                context.SetUserValue(triggerID: 9340, key: "Box34Check", value: 2);
                context.SetUserValue(triggerID: 9410, key: "Box41Check", value: 3);
                context.SetUserValue(triggerID: 9420, key: "Box42Check", value: 4);
                context.SetUserValue(triggerID: 9430, key: "Box43Check", value: 1);
                context.SetUserValue(triggerID: 9440, key: "Box44Check", value: 3);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP31(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP31 : TriggerState {
            internal StateNumberOffP31(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {113}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {125}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {132}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {144}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {215}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {221}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {234}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {245}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {315}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {324}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {335}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {342}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {413}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {424}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {431}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {443}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP31(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP31 : TriggerState {
            internal StateResetP31(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 1, key: "G05P31End", value: 1);
                context.SetUserValue(key: "G05P31Set", value: 0);
                context.SetUserValue(key: "G05P31TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP32 : TriggerState {
            internal StateNumberOnP32(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new int[] {112}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {124}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {133}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {145}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {214}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {221}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {235}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {243}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {315}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {321}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {333}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {344}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {415}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {425}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {434}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {442}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerID: 8110, key: "Barrier11", value: 2);
                context.SetUserValue(triggerID: 8120, key: "Barrier12", value: 4);
                context.SetUserValue(triggerID: 8130, key: "Barrier13", value: 3);
                context.SetUserValue(triggerID: 8140, key: "Barrier14", value: 5);
                context.SetUserValue(triggerID: 8210, key: "Barrier21", value: 4);
                context.SetUserValue(triggerID: 8220, key: "Barrier22", value: 1);
                context.SetUserValue(triggerID: 8230, key: "Barrier23", value: 5);
                context.SetUserValue(triggerID: 8240, key: "Barrier24", value: 3);
                context.SetUserValue(triggerID: 8310, key: "Barrier31", value: 5);
                context.SetUserValue(triggerID: 8320, key: "Barrier32", value: 1);
                context.SetUserValue(triggerID: 8330, key: "Barrier33", value: 3);
                context.SetUserValue(triggerID: 8340, key: "Barrier34", value: 4);
                context.SetUserValue(triggerID: 8410, key: "Barrier41", value: 5);
                context.SetUserValue(triggerID: 8420, key: "Barrier42", value: 5);
                context.SetUserValue(triggerID: 8430, key: "Barrier43", value: 4);
                context.SetUserValue(triggerID: 8440, key: "Barrier44", value: 2);
            }

            public override void Execute() {
                if (context.UserValue(key: "G05P32TimeLimit", value: 1)) {
                    context.State = new StateCheckP32(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP32 : TriggerState {
            internal StateCheckP32(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 9110, key: "Box11Check", value: 2);
                context.SetUserValue(triggerID: 9120, key: "Box12Check", value: 4);
                context.SetUserValue(triggerID: 9130, key: "Box13Check", value: 3);
                context.SetUserValue(triggerID: 9140, key: "Box14Check", value: 5);
                context.SetUserValue(triggerID: 9210, key: "Box21Check", value: 4);
                context.SetUserValue(triggerID: 9220, key: "Box22Check", value: 1);
                context.SetUserValue(triggerID: 9230, key: "Box23Check", value: 5);
                context.SetUserValue(triggerID: 9240, key: "Box24Check", value: 3);
                context.SetUserValue(triggerID: 9310, key: "Box31Check", value: 5);
                context.SetUserValue(triggerID: 9320, key: "Box32Check", value: 1);
                context.SetUserValue(triggerID: 9330, key: "Box33Check", value: 3);
                context.SetUserValue(triggerID: 9340, key: "Box34Check", value: 4);
                context.SetUserValue(triggerID: 9410, key: "Box41Check", value: 5);
                context.SetUserValue(triggerID: 9420, key: "Box42Check", value: 5);
                context.SetUserValue(triggerID: 9430, key: "Box43Check", value: 4);
                context.SetUserValue(triggerID: 9440, key: "Box44Check", value: 2);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP32(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP32 : TriggerState {
            internal StateNumberOffP32(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {112}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {124}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {133}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {145}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {214}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {221}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {235}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {243}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {315}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {321}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {333}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {344}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {415}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {425}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {434}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {442}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP32(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP32 : TriggerState {
            internal StateResetP32(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 1, key: "G05P32End", value: 1);
                context.SetUserValue(key: "G05P32Set", value: 0);
                context.SetUserValue(key: "G05P32TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP33 : TriggerState {
            internal StateNumberOnP33(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new int[] {115}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {122}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {135}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {143}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {215}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {225}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {231}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {245}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {312}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {325}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {335}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {343}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {415}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {423}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {435}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {441}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerID: 8110, key: "Barrier11", value: 5);
                context.SetUserValue(triggerID: 8120, key: "Barrier12", value: 2);
                context.SetUserValue(triggerID: 8130, key: "Barrier13", value: 5);
                context.SetUserValue(triggerID: 8140, key: "Barrier14", value: 3);
                context.SetUserValue(triggerID: 8210, key: "Barrier21", value: 5);
                context.SetUserValue(triggerID: 8220, key: "Barrier22", value: 5);
                context.SetUserValue(triggerID: 8230, key: "Barrier23", value: 1);
                context.SetUserValue(triggerID: 8240, key: "Barrier24", value: 5);
                context.SetUserValue(triggerID: 8310, key: "Barrier31", value: 2);
                context.SetUserValue(triggerID: 8320, key: "Barrier32", value: 5);
                context.SetUserValue(triggerID: 8330, key: "Barrier33", value: 5);
                context.SetUserValue(triggerID: 8340, key: "Barrier34", value: 3);
                context.SetUserValue(triggerID: 8410, key: "Barrier41", value: 5);
                context.SetUserValue(triggerID: 8420, key: "Barrier42", value: 3);
                context.SetUserValue(triggerID: 8430, key: "Barrier43", value: 5);
                context.SetUserValue(triggerID: 8440, key: "Barrier44", value: 1);
            }

            public override void Execute() {
                if (context.UserValue(key: "G05P33TimeLimit", value: 1)) {
                    context.State = new StateCheckP33(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP33 : TriggerState {
            internal StateCheckP33(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 9110, key: "Box11Check", value: 5);
                context.SetUserValue(triggerID: 9120, key: "Box12Check", value: 2);
                context.SetUserValue(triggerID: 9130, key: "Box13Check", value: 5);
                context.SetUserValue(triggerID: 9140, key: "Box14Check", value: 3);
                context.SetUserValue(triggerID: 9210, key: "Box21Check", value: 5);
                context.SetUserValue(triggerID: 9220, key: "Box22Check", value: 5);
                context.SetUserValue(triggerID: 9230, key: "Box23Check", value: 1);
                context.SetUserValue(triggerID: 9240, key: "Box24Check", value: 5);
                context.SetUserValue(triggerID: 9310, key: "Box31Check", value: 2);
                context.SetUserValue(triggerID: 9320, key: "Box32Check", value: 5);
                context.SetUserValue(triggerID: 9330, key: "Box33Check", value: 5);
                context.SetUserValue(triggerID: 9340, key: "Box34Check", value: 3);
                context.SetUserValue(triggerID: 9410, key: "Box41Check", value: 5);
                context.SetUserValue(triggerID: 9420, key: "Box42Check", value: 3);
                context.SetUserValue(triggerID: 9430, key: "Box43Check", value: 5);
                context.SetUserValue(triggerID: 9440, key: "Box44Check", value: 1);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP33(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP33 : TriggerState {
            internal StateNumberOffP33(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {115}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {122}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {135}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {143}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {215}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {225}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {231}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {245}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {312}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {325}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {335}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {343}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {415}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {423}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {435}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {441}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP33(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP33 : TriggerState {
            internal StateResetP33(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 1, key: "G05P33End", value: 1);
                context.SetUserValue(key: "G05P33Set", value: 0);
                context.SetUserValue(key: "G05P33TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP34 : TriggerState {
            internal StateNumberOnP34(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new int[] {114}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {122}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {134}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {145}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {212}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {225}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {235}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {241}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {315}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {324}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {331}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {345}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {415}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {425}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {434}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {442}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerID: 8110, key: "Barrier11", value: 4);
                context.SetUserValue(triggerID: 8120, key: "Barrier12", value: 2);
                context.SetUserValue(triggerID: 8130, key: "Barrier13", value: 4);
                context.SetUserValue(triggerID: 8140, key: "Barrier14", value: 5);
                context.SetUserValue(triggerID: 8210, key: "Barrier21", value: 2);
                context.SetUserValue(triggerID: 8220, key: "Barrier22", value: 5);
                context.SetUserValue(triggerID: 8230, key: "Barrier23", value: 5);
                context.SetUserValue(triggerID: 8240, key: "Barrier24", value: 1);
                context.SetUserValue(triggerID: 8310, key: "Barrier31", value: 5);
                context.SetUserValue(triggerID: 8320, key: "Barrier32", value: 4);
                context.SetUserValue(triggerID: 8330, key: "Barrier33", value: 1);
                context.SetUserValue(triggerID: 8340, key: "Barrier34", value: 5);
                context.SetUserValue(triggerID: 8410, key: "Barrier41", value: 5);
                context.SetUserValue(triggerID: 8420, key: "Barrier42", value: 5);
                context.SetUserValue(triggerID: 8430, key: "Barrier43", value: 4);
                context.SetUserValue(triggerID: 8440, key: "Barrier44", value: 2);
            }

            public override void Execute() {
                if (context.UserValue(key: "G05P34TimeLimit", value: 1)) {
                    context.State = new StateCheckP34(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP34 : TriggerState {
            internal StateCheckP34(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 9110, key: "Box11Check", value: 4);
                context.SetUserValue(triggerID: 9120, key: "Box12Check", value: 2);
                context.SetUserValue(triggerID: 9130, key: "Box13Check", value: 4);
                context.SetUserValue(triggerID: 9140, key: "Box14Check", value: 5);
                context.SetUserValue(triggerID: 9210, key: "Box21Check", value: 2);
                context.SetUserValue(triggerID: 9220, key: "Box22Check", value: 5);
                context.SetUserValue(triggerID: 9230, key: "Box23Check", value: 5);
                context.SetUserValue(triggerID: 9240, key: "Box24Check", value: 1);
                context.SetUserValue(triggerID: 9310, key: "Box31Check", value: 5);
                context.SetUserValue(triggerID: 9320, key: "Box32Check", value: 4);
                context.SetUserValue(triggerID: 9330, key: "Box33Check", value: 1);
                context.SetUserValue(triggerID: 9340, key: "Box34Check", value: 5);
                context.SetUserValue(triggerID: 9410, key: "Box41Check", value: 5);
                context.SetUserValue(triggerID: 9420, key: "Box42Check", value: 5);
                context.SetUserValue(triggerID: 9430, key: "Box43Check", value: 4);
                context.SetUserValue(triggerID: 9440, key: "Box44Check", value: 2);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP34(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP34 : TriggerState {
            internal StateNumberOffP34(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {114}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {122}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {134}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {145}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {212}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {225}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {235}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {241}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {315}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {324}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {331}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {345}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {415}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {425}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {434}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {442}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP34(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP34 : TriggerState {
            internal StateResetP34(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 1, key: "G05P34End", value: 1);
                context.SetUserValue(key: "G05P34Set", value: 0);
                context.SetUserValue(key: "G05P34TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP35 : TriggerState {
            internal StateNumberOnP35(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new int[] {114}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {124}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {133}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {144}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {212}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {223}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {231}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {244}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {314}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {321}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {333}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {342}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {414}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {423}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {434}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {444}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerID: 8110, key: "Barrier11", value: 4);
                context.SetUserValue(triggerID: 8120, key: "Barrier12", value: 4);
                context.SetUserValue(triggerID: 8130, key: "Barrier13", value: 3);
                context.SetUserValue(triggerID: 8140, key: "Barrier14", value: 4);
                context.SetUserValue(triggerID: 8210, key: "Barrier21", value: 2);
                context.SetUserValue(triggerID: 8220, key: "Barrier22", value: 3);
                context.SetUserValue(triggerID: 8230, key: "Barrier23", value: 1);
                context.SetUserValue(triggerID: 8240, key: "Barrier24", value: 4);
                context.SetUserValue(triggerID: 8310, key: "Barrier31", value: 4);
                context.SetUserValue(triggerID: 8320, key: "Barrier32", value: 1);
                context.SetUserValue(triggerID: 8330, key: "Barrier33", value: 3);
                context.SetUserValue(triggerID: 8340, key: "Barrier34", value: 2);
                context.SetUserValue(triggerID: 8410, key: "Barrier41", value: 4);
                context.SetUserValue(triggerID: 8420, key: "Barrier42", value: 3);
                context.SetUserValue(triggerID: 8430, key: "Barrier43", value: 4);
                context.SetUserValue(triggerID: 8440, key: "Barrier44", value: 4);
            }

            public override void Execute() {
                if (context.UserValue(key: "G05P35TimeLimit", value: 1)) {
                    context.State = new StateCheckP35(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP35 : TriggerState {
            internal StateCheckP35(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 9110, key: "Box11Check", value: 4);
                context.SetUserValue(triggerID: 9120, key: "Box12Check", value: 4);
                context.SetUserValue(triggerID: 9130, key: "Box13Check", value: 3);
                context.SetUserValue(triggerID: 9140, key: "Box14Check", value: 4);
                context.SetUserValue(triggerID: 9210, key: "Box21Check", value: 2);
                context.SetUserValue(triggerID: 9220, key: "Box22Check", value: 3);
                context.SetUserValue(triggerID: 9230, key: "Box23Check", value: 1);
                context.SetUserValue(triggerID: 9240, key: "Box24Check", value: 4);
                context.SetUserValue(triggerID: 9310, key: "Box31Check", value: 4);
                context.SetUserValue(triggerID: 9320, key: "Box32Check", value: 1);
                context.SetUserValue(triggerID: 9330, key: "Box33Check", value: 3);
                context.SetUserValue(triggerID: 9340, key: "Box34Check", value: 2);
                context.SetUserValue(triggerID: 9410, key: "Box41Check", value: 4);
                context.SetUserValue(triggerID: 9420, key: "Box42Check", value: 3);
                context.SetUserValue(triggerID: 9430, key: "Box43Check", value: 4);
                context.SetUserValue(triggerID: 9440, key: "Box44Check", value: 4);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP35(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP35 : TriggerState {
            internal StateNumberOffP35(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {114}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {124}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {133}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {144}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {212}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {223}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {231}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {244}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {314}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {321}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {333}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {342}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {414}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {423}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {434}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {444}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP35(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP35 : TriggerState {
            internal StateResetP35(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 1, key: "G05P35End", value: 1);
                context.SetUserValue(key: "G05P35Set", value: 0);
                context.SetUserValue(key: "G05P35TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP36 : TriggerState {
            internal StateNumberOnP36(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new int[] {112}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {124}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {131}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {142}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {214}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {224}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {235}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {244}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {315}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {321}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {334}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {345}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {412}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {424}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {434}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {441}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerID: 8110, key: "Barrier11", value: 2);
                context.SetUserValue(triggerID: 8120, key: "Barrier12", value: 4);
                context.SetUserValue(triggerID: 8130, key: "Barrier13", value: 1);
                context.SetUserValue(triggerID: 8140, key: "Barrier14", value: 2);
                context.SetUserValue(triggerID: 8210, key: "Barrier21", value: 4);
                context.SetUserValue(triggerID: 8220, key: "Barrier22", value: 4);
                context.SetUserValue(triggerID: 8230, key: "Barrier23", value: 5);
                context.SetUserValue(triggerID: 8240, key: "Barrier24", value: 4);
                context.SetUserValue(triggerID: 8310, key: "Barrier31", value: 5);
                context.SetUserValue(triggerID: 8320, key: "Barrier32", value: 1);
                context.SetUserValue(triggerID: 8330, key: "Barrier33", value: 4);
                context.SetUserValue(triggerID: 8340, key: "Barrier34", value: 5);
                context.SetUserValue(triggerID: 8410, key: "Barrier41", value: 2);
                context.SetUserValue(triggerID: 8420, key: "Barrier42", value: 4);
                context.SetUserValue(triggerID: 8430, key: "Barrier43", value: 4);
                context.SetUserValue(triggerID: 8440, key: "Barrier44", value: 1);
            }

            public override void Execute() {
                if (context.UserValue(key: "G05P36TimeLimit", value: 1)) {
                    context.State = new StateCheckP36(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP36 : TriggerState {
            internal StateCheckP36(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 9110, key: "Box11Check", value: 2);
                context.SetUserValue(triggerID: 9120, key: "Box12Check", value: 4);
                context.SetUserValue(triggerID: 9130, key: "Box13Check", value: 1);
                context.SetUserValue(triggerID: 9140, key: "Box14Check", value: 2);
                context.SetUserValue(triggerID: 9210, key: "Box21Check", value: 4);
                context.SetUserValue(triggerID: 9220, key: "Box22Check", value: 4);
                context.SetUserValue(triggerID: 9230, key: "Box23Check", value: 5);
                context.SetUserValue(triggerID: 9240, key: "Box24Check", value: 4);
                context.SetUserValue(triggerID: 9310, key: "Box31Check", value: 5);
                context.SetUserValue(triggerID: 9320, key: "Box32Check", value: 1);
                context.SetUserValue(triggerID: 9330, key: "Box33Check", value: 4);
                context.SetUserValue(triggerID: 9340, key: "Box34Check", value: 5);
                context.SetUserValue(triggerID: 9410, key: "Box41Check", value: 2);
                context.SetUserValue(triggerID: 9420, key: "Box42Check", value: 4);
                context.SetUserValue(triggerID: 9430, key: "Box43Check", value: 4);
                context.SetUserValue(triggerID: 9440, key: "Box44Check", value: 1);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP36(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP36 : TriggerState {
            internal StateNumberOffP36(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {112}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {124}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {131}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {142}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {214}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {224}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {235}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {244}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {315}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {321}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {334}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {345}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {412}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {424}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {434}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {441}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP36(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP36 : TriggerState {
            internal StateResetP36(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 1, key: "G05P36End", value: 1);
                context.SetUserValue(key: "G05P36Set", value: 0);
                context.SetUserValue(key: "G05P36TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP37 : TriggerState {
            internal StateNumberOnP37(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new int[] {113}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {123}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {135}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {143}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {211}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {223}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {235}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {241}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {313}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {325}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {333}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {343}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {411}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {423}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {435}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {443}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerID: 8110, key: "Barrier11", value: 3);
                context.SetUserValue(triggerID: 8120, key: "Barrier12", value: 3);
                context.SetUserValue(triggerID: 8130, key: "Barrier13", value: 5);
                context.SetUserValue(triggerID: 8140, key: "Barrier14", value: 3);
                context.SetUserValue(triggerID: 8210, key: "Barrier21", value: 1);
                context.SetUserValue(triggerID: 8220, key: "Barrier22", value: 3);
                context.SetUserValue(triggerID: 8230, key: "Barrier23", value: 5);
                context.SetUserValue(triggerID: 8240, key: "Barrier24", value: 1);
                context.SetUserValue(triggerID: 8310, key: "Barrier31", value: 3);
                context.SetUserValue(triggerID: 8320, key: "Barrier32", value: 5);
                context.SetUserValue(triggerID: 8330, key: "Barrier33", value: 3);
                context.SetUserValue(triggerID: 8340, key: "Barrier34", value: 3);
                context.SetUserValue(triggerID: 8410, key: "Barrier41", value: 1);
                context.SetUserValue(triggerID: 8420, key: "Barrier42", value: 3);
                context.SetUserValue(triggerID: 8430, key: "Barrier43", value: 5);
                context.SetUserValue(triggerID: 8440, key: "Barrier44", value: 3);
            }

            public override void Execute() {
                if (context.UserValue(key: "G05P37TimeLimit", value: 1)) {
                    context.State = new StateCheckP37(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP37 : TriggerState {
            internal StateCheckP37(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 9110, key: "Box11Check", value: 3);
                context.SetUserValue(triggerID: 9120, key: "Box12Check", value: 3);
                context.SetUserValue(triggerID: 9130, key: "Box13Check", value: 5);
                context.SetUserValue(triggerID: 9140, key: "Box14Check", value: 3);
                context.SetUserValue(triggerID: 9210, key: "Box21Check", value: 1);
                context.SetUserValue(triggerID: 9220, key: "Box22Check", value: 3);
                context.SetUserValue(triggerID: 9230, key: "Box23Check", value: 5);
                context.SetUserValue(triggerID: 9240, key: "Box24Check", value: 1);
                context.SetUserValue(triggerID: 9310, key: "Box31Check", value: 3);
                context.SetUserValue(triggerID: 9320, key: "Box32Check", value: 5);
                context.SetUserValue(triggerID: 9330, key: "Box33Check", value: 3);
                context.SetUserValue(triggerID: 9340, key: "Box34Check", value: 3);
                context.SetUserValue(triggerID: 9410, key: "Box41Check", value: 1);
                context.SetUserValue(triggerID: 9420, key: "Box42Check", value: 3);
                context.SetUserValue(triggerID: 9430, key: "Box43Check", value: 5);
                context.SetUserValue(triggerID: 9440, key: "Box44Check", value: 3);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP37(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP37 : TriggerState {
            internal StateNumberOffP37(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {113}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {123}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {135}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {143}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {211}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {223}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {235}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {241}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {313}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {325}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {333}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {343}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {411}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {423}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {435}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {443}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP37(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP37 : TriggerState {
            internal StateResetP37(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 1, key: "G05P37End", value: 1);
                context.SetUserValue(key: "G05P37Set", value: 0);
                context.SetUserValue(key: "G05P37TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP38 : TriggerState {
            internal StateNumberOnP38(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new int[] {115}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {124}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {133}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {144}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {215}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {223}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {233}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {241}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {314}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {321}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {335}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {343}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {413}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {424}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {434}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {445}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerID: 8110, key: "Barrier11", value: 5);
                context.SetUserValue(triggerID: 8120, key: "Barrier12", value: 4);
                context.SetUserValue(triggerID: 8130, key: "Barrier13", value: 3);
                context.SetUserValue(triggerID: 8140, key: "Barrier14", value: 4);
                context.SetUserValue(triggerID: 8210, key: "Barrier21", value: 5);
                context.SetUserValue(triggerID: 8220, key: "Barrier22", value: 3);
                context.SetUserValue(triggerID: 8230, key: "Barrier23", value: 3);
                context.SetUserValue(triggerID: 8240, key: "Barrier24", value: 1);
                context.SetUserValue(triggerID: 8310, key: "Barrier31", value: 4);
                context.SetUserValue(triggerID: 8320, key: "Barrier32", value: 1);
                context.SetUserValue(triggerID: 8330, key: "Barrier33", value: 5);
                context.SetUserValue(triggerID: 8340, key: "Barrier34", value: 3);
                context.SetUserValue(triggerID: 8410, key: "Barrier41", value: 3);
                context.SetUserValue(triggerID: 8420, key: "Barrier42", value: 4);
                context.SetUserValue(triggerID: 8430, key: "Barrier43", value: 4);
                context.SetUserValue(triggerID: 8440, key: "Barrier44", value: 5);
            }

            public override void Execute() {
                if (context.UserValue(key: "G05P38TimeLimit", value: 1)) {
                    context.State = new StateCheckP38(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP38 : TriggerState {
            internal StateCheckP38(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 9110, key: "Box11Check", value: 5);
                context.SetUserValue(triggerID: 9120, key: "Box12Check", value: 4);
                context.SetUserValue(triggerID: 9130, key: "Box13Check", value: 3);
                context.SetUserValue(triggerID: 9140, key: "Box14Check", value: 4);
                context.SetUserValue(triggerID: 9210, key: "Box21Check", value: 5);
                context.SetUserValue(triggerID: 9220, key: "Box22Check", value: 3);
                context.SetUserValue(triggerID: 9230, key: "Box23Check", value: 3);
                context.SetUserValue(triggerID: 9240, key: "Box24Check", value: 1);
                context.SetUserValue(triggerID: 9310, key: "Box31Check", value: 4);
                context.SetUserValue(triggerID: 9320, key: "Box32Check", value: 1);
                context.SetUserValue(triggerID: 9330, key: "Box33Check", value: 5);
                context.SetUserValue(triggerID: 9340, key: "Box34Check", value: 3);
                context.SetUserValue(triggerID: 9410, key: "Box41Check", value: 3);
                context.SetUserValue(triggerID: 9420, key: "Box42Check", value: 4);
                context.SetUserValue(triggerID: 9430, key: "Box43Check", value: 4);
                context.SetUserValue(triggerID: 9440, key: "Box44Check", value: 5);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP38(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP38 : TriggerState {
            internal StateNumberOffP38(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {115}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {124}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {133}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {144}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {215}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {223}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {233}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {241}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {314}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {321}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {335}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {343}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {413}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {424}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {434}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {445}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP38(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP38 : TriggerState {
            internal StateResetP38(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 1, key: "G05P38End", value: 1);
                context.SetUserValue(key: "G05P38Set", value: 0);
                context.SetUserValue(key: "G05P38TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP39 : TriggerState {
            internal StateNumberOnP39(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new int[] {113}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {122}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {134}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {141}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {213}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {225}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {232}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {245}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {311}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {324}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {333}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {344}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {414}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {423}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {435}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {443}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerID: 8110, key: "Barrier11", value: 3);
                context.SetUserValue(triggerID: 8120, key: "Barrier12", value: 2);
                context.SetUserValue(triggerID: 8130, key: "Barrier13", value: 4);
                context.SetUserValue(triggerID: 8140, key: "Barrier14", value: 1);
                context.SetUserValue(triggerID: 8210, key: "Barrier21", value: 3);
                context.SetUserValue(triggerID: 8220, key: "Barrier22", value: 5);
                context.SetUserValue(triggerID: 8230, key: "Barrier23", value: 2);
                context.SetUserValue(triggerID: 8240, key: "Barrier24", value: 5);
                context.SetUserValue(triggerID: 8310, key: "Barrier31", value: 1);
                context.SetUserValue(triggerID: 8320, key: "Barrier32", value: 4);
                context.SetUserValue(triggerID: 8330, key: "Barrier33", value: 3);
                context.SetUserValue(triggerID: 8340, key: "Barrier34", value: 4);
                context.SetUserValue(triggerID: 8410, key: "Barrier41", value: 4);
                context.SetUserValue(triggerID: 8420, key: "Barrier42", value: 3);
                context.SetUserValue(triggerID: 8430, key: "Barrier43", value: 5);
                context.SetUserValue(triggerID: 8440, key: "Barrier44", value: 3);
            }

            public override void Execute() {
                if (context.UserValue(key: "G05P39TimeLimit", value: 1)) {
                    context.State = new StateCheckP39(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP39 : TriggerState {
            internal StateCheckP39(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 9110, key: "Box11Check", value: 3);
                context.SetUserValue(triggerID: 9120, key: "Box12Check", value: 2);
                context.SetUserValue(triggerID: 9130, key: "Box13Check", value: 4);
                context.SetUserValue(triggerID: 9140, key: "Box14Check", value: 1);
                context.SetUserValue(triggerID: 9210, key: "Box21Check", value: 3);
                context.SetUserValue(triggerID: 9220, key: "Box22Check", value: 5);
                context.SetUserValue(triggerID: 9230, key: "Box23Check", value: 2);
                context.SetUserValue(triggerID: 9240, key: "Box24Check", value: 5);
                context.SetUserValue(triggerID: 9310, key: "Box31Check", value: 1);
                context.SetUserValue(triggerID: 9320, key: "Box32Check", value: 4);
                context.SetUserValue(triggerID: 9330, key: "Box33Check", value: 3);
                context.SetUserValue(triggerID: 9340, key: "Box34Check", value: 4);
                context.SetUserValue(triggerID: 9410, key: "Box41Check", value: 4);
                context.SetUserValue(triggerID: 9420, key: "Box42Check", value: 3);
                context.SetUserValue(triggerID: 9430, key: "Box43Check", value: 5);
                context.SetUserValue(triggerID: 9440, key: "Box44Check", value: 3);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP39(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP39 : TriggerState {
            internal StateNumberOffP39(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {113}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {122}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {134}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {141}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {213}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {225}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {232}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {245}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {311}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {324}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {333}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {344}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {414}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {423}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {435}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {443}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP39(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP39 : TriggerState {
            internal StateResetP39(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 1, key: "G05P39End", value: 1);
                context.SetUserValue(key: "G05P39Set", value: 0);
                context.SetUserValue(key: "G05P39TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP40 : TriggerState {
            internal StateNumberOnP40(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new int[] {113}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {121}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {135}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {142}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {214}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {223}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {234}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {241}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {315}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {324}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {333}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {344}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {413}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {425}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {432}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {443}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerID: 8110, key: "Barrier11", value: 3);
                context.SetUserValue(triggerID: 8120, key: "Barrier12", value: 1);
                context.SetUserValue(triggerID: 8130, key: "Barrier13", value: 5);
                context.SetUserValue(triggerID: 8140, key: "Barrier14", value: 2);
                context.SetUserValue(triggerID: 8210, key: "Barrier21", value: 4);
                context.SetUserValue(triggerID: 8220, key: "Barrier22", value: 3);
                context.SetUserValue(triggerID: 8230, key: "Barrier23", value: 4);
                context.SetUserValue(triggerID: 8240, key: "Barrier24", value: 1);
                context.SetUserValue(triggerID: 8310, key: "Barrier31", value: 5);
                context.SetUserValue(triggerID: 8320, key: "Barrier32", value: 4);
                context.SetUserValue(triggerID: 8330, key: "Barrier33", value: 3);
                context.SetUserValue(triggerID: 8340, key: "Barrier34", value: 4);
                context.SetUserValue(triggerID: 8410, key: "Barrier41", value: 3);
                context.SetUserValue(triggerID: 8420, key: "Barrier42", value: 5);
                context.SetUserValue(triggerID: 8430, key: "Barrier43", value: 2);
                context.SetUserValue(triggerID: 8440, key: "Barrier44", value: 3);
            }

            public override void Execute() {
                if (context.UserValue(key: "G05P40TimeLimit", value: 1)) {
                    context.State = new StateCheckP40(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP40 : TriggerState {
            internal StateCheckP40(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 9110, key: "Box11Check", value: 3);
                context.SetUserValue(triggerID: 9120, key: "Box12Check", value: 1);
                context.SetUserValue(triggerID: 9130, key: "Box13Check", value: 5);
                context.SetUserValue(triggerID: 9140, key: "Box14Check", value: 2);
                context.SetUserValue(triggerID: 9210, key: "Box21Check", value: 4);
                context.SetUserValue(triggerID: 9220, key: "Box22Check", value: 3);
                context.SetUserValue(triggerID: 9230, key: "Box23Check", value: 4);
                context.SetUserValue(triggerID: 9240, key: "Box24Check", value: 1);
                context.SetUserValue(triggerID: 9310, key: "Box31Check", value: 5);
                context.SetUserValue(triggerID: 9320, key: "Box32Check", value: 4);
                context.SetUserValue(triggerID: 9330, key: "Box33Check", value: 3);
                context.SetUserValue(triggerID: 9340, key: "Box34Check", value: 4);
                context.SetUserValue(triggerID: 9410, key: "Box41Check", value: 3);
                context.SetUserValue(triggerID: 9420, key: "Box42Check", value: 5);
                context.SetUserValue(triggerID: 9430, key: "Box43Check", value: 2);
                context.SetUserValue(triggerID: 9440, key: "Box44Check", value: 3);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP40(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP40 : TriggerState {
            internal StateNumberOffP40(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {113}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {121}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {135}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {142}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {214}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {223}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {234}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {241}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {315}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {324}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {333}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {344}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {413}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {425}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {432}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {443}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP40(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP40 : TriggerState {
            internal StateResetP40(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 1, key: "G05P40End", value: 1);
                context.SetUserValue(key: "G05P40Set", value: 0);
                context.SetUserValue(key: "G05P40TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP41 : TriggerState {
            internal StateNumberOnP41(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new int[] {115}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {125}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {135}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {145}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {215}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {221}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {232}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {245}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {315}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {322}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {331}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {345}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {415}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {425}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {435}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {445}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerID: 8110, key: "Barrier11", value: 5);
                context.SetUserValue(triggerID: 8120, key: "Barrier12", value: 5);
                context.SetUserValue(triggerID: 8130, key: "Barrier13", value: 5);
                context.SetUserValue(triggerID: 8140, key: "Barrier14", value: 5);
                context.SetUserValue(triggerID: 8210, key: "Barrier21", value: 5);
                context.SetUserValue(triggerID: 8220, key: "Barrier22", value: 1);
                context.SetUserValue(triggerID: 8230, key: "Barrier23", value: 2);
                context.SetUserValue(triggerID: 8240, key: "Barrier24", value: 5);
                context.SetUserValue(triggerID: 8310, key: "Barrier31", value: 5);
                context.SetUserValue(triggerID: 8320, key: "Barrier32", value: 2);
                context.SetUserValue(triggerID: 8330, key: "Barrier33", value: 1);
                context.SetUserValue(triggerID: 8340, key: "Barrier34", value: 5);
                context.SetUserValue(triggerID: 8410, key: "Barrier41", value: 5);
                context.SetUserValue(triggerID: 8420, key: "Barrier42", value: 5);
                context.SetUserValue(triggerID: 8430, key: "Barrier43", value: 5);
                context.SetUserValue(triggerID: 8440, key: "Barrier44", value: 5);
            }

            public override void Execute() {
                if (context.UserValue(key: "G05P41TimeLimit", value: 1)) {
                    context.State = new StateCheckP41(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP41 : TriggerState {
            internal StateCheckP41(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 9110, key: "Box11Check", value: 5);
                context.SetUserValue(triggerID: 9120, key: "Box12Check", value: 5);
                context.SetUserValue(triggerID: 9130, key: "Box13Check", value: 5);
                context.SetUserValue(triggerID: 9140, key: "Box14Check", value: 5);
                context.SetUserValue(triggerID: 9210, key: "Box21Check", value: 5);
                context.SetUserValue(triggerID: 9220, key: "Box22Check", value: 1);
                context.SetUserValue(triggerID: 9230, key: "Box23Check", value: 2);
                context.SetUserValue(triggerID: 9240, key: "Box24Check", value: 5);
                context.SetUserValue(triggerID: 9310, key: "Box31Check", value: 5);
                context.SetUserValue(triggerID: 9320, key: "Box32Check", value: 2);
                context.SetUserValue(triggerID: 9330, key: "Box33Check", value: 1);
                context.SetUserValue(triggerID: 9340, key: "Box34Check", value: 5);
                context.SetUserValue(triggerID: 9410, key: "Box41Check", value: 5);
                context.SetUserValue(triggerID: 9420, key: "Box42Check", value: 5);
                context.SetUserValue(triggerID: 9430, key: "Box43Check", value: 5);
                context.SetUserValue(triggerID: 9440, key: "Box44Check", value: 5);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP41(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP41 : TriggerState {
            internal StateNumberOffP41(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {115}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {125}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {135}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {145}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {215}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {221}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {232}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {245}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {315}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {322}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {331}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {345}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {415}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {425}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {435}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {445}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP41(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP41 : TriggerState {
            internal StateResetP41(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 1, key: "G05P41End", value: 1);
                context.SetUserValue(key: "G05P41Set", value: 0);
                context.SetUserValue(key: "G05P41TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP42 : TriggerState {
            internal StateNumberOnP42(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new int[] {113}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {125}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {135}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {142}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {215}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {223}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {232}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {245}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {315}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {322}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {333}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {345}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {412}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {425}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {435}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {443}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerID: 8110, key: "Barrier11", value: 3);
                context.SetUserValue(triggerID: 8120, key: "Barrier12", value: 5);
                context.SetUserValue(triggerID: 8130, key: "Barrier13", value: 5);
                context.SetUserValue(triggerID: 8140, key: "Barrier14", value: 2);
                context.SetUserValue(triggerID: 8210, key: "Barrier21", value: 5);
                context.SetUserValue(triggerID: 8220, key: "Barrier22", value: 3);
                context.SetUserValue(triggerID: 8230, key: "Barrier23", value: 2);
                context.SetUserValue(triggerID: 8240, key: "Barrier24", value: 5);
                context.SetUserValue(triggerID: 8310, key: "Barrier31", value: 5);
                context.SetUserValue(triggerID: 8320, key: "Barrier32", value: 2);
                context.SetUserValue(triggerID: 8330, key: "Barrier33", value: 3);
                context.SetUserValue(triggerID: 8340, key: "Barrier34", value: 5);
                context.SetUserValue(triggerID: 8410, key: "Barrier41", value: 2);
                context.SetUserValue(triggerID: 8420, key: "Barrier42", value: 5);
                context.SetUserValue(triggerID: 8430, key: "Barrier43", value: 5);
                context.SetUserValue(triggerID: 8440, key: "Barrier44", value: 3);
            }

            public override void Execute() {
                if (context.UserValue(key: "G05P42TimeLimit", value: 1)) {
                    context.State = new StateCheckP42(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP42 : TriggerState {
            internal StateCheckP42(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 9110, key: "Box11Check", value: 3);
                context.SetUserValue(triggerID: 9120, key: "Box12Check", value: 5);
                context.SetUserValue(triggerID: 9130, key: "Box13Check", value: 5);
                context.SetUserValue(triggerID: 9140, key: "Box14Check", value: 2);
                context.SetUserValue(triggerID: 9210, key: "Box21Check", value: 5);
                context.SetUserValue(triggerID: 9220, key: "Box22Check", value: 3);
                context.SetUserValue(triggerID: 9230, key: "Box23Check", value: 2);
                context.SetUserValue(triggerID: 9240, key: "Box24Check", value: 5);
                context.SetUserValue(triggerID: 9310, key: "Box31Check", value: 5);
                context.SetUserValue(triggerID: 9320, key: "Box32Check", value: 2);
                context.SetUserValue(triggerID: 9330, key: "Box33Check", value: 3);
                context.SetUserValue(triggerID: 9340, key: "Box34Check", value: 5);
                context.SetUserValue(triggerID: 9410, key: "Box41Check", value: 2);
                context.SetUserValue(triggerID: 9420, key: "Box42Check", value: 5);
                context.SetUserValue(triggerID: 9430, key: "Box43Check", value: 5);
                context.SetUserValue(triggerID: 9440, key: "Box44Check", value: 3);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP42(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP42 : TriggerState {
            internal StateNumberOffP42(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {113}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {125}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {135}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {142}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {215}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {223}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {232}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {245}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {315}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {322}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {333}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {345}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {412}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {425}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {435}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {443}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP42(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP42 : TriggerState {
            internal StateResetP42(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 1, key: "G05P42End", value: 1);
                context.SetUserValue(key: "G05P42Set", value: 0);
                context.SetUserValue(key: "G05P42TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP43 : TriggerState {
            internal StateNumberOnP43(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new int[] {112}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {125}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {135}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {143}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {214}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {225}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {235}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {244}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {314}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {325}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {335}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {343}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {413}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {422}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {435}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {442}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerID: 8110, key: "Barrier11", value: 2);
                context.SetUserValue(triggerID: 8120, key: "Barrier12", value: 5);
                context.SetUserValue(triggerID: 8130, key: "Barrier13", value: 5);
                context.SetUserValue(triggerID: 8140, key: "Barrier14", value: 3);
                context.SetUserValue(triggerID: 8210, key: "Barrier21", value: 4);
                context.SetUserValue(triggerID: 8220, key: "Barrier22", value: 5);
                context.SetUserValue(triggerID: 8230, key: "Barrier23", value: 5);
                context.SetUserValue(triggerID: 8240, key: "Barrier24", value: 4);
                context.SetUserValue(triggerID: 8310, key: "Barrier31", value: 4);
                context.SetUserValue(triggerID: 8320, key: "Barrier32", value: 5);
                context.SetUserValue(triggerID: 8330, key: "Barrier33", value: 5);
                context.SetUserValue(triggerID: 8340, key: "Barrier34", value: 3);
                context.SetUserValue(triggerID: 8410, key: "Barrier41", value: 3);
                context.SetUserValue(triggerID: 8420, key: "Barrier42", value: 2);
                context.SetUserValue(triggerID: 8430, key: "Barrier43", value: 5);
                context.SetUserValue(triggerID: 8440, key: "Barrier44", value: 2);
            }

            public override void Execute() {
                if (context.UserValue(key: "G05P43TimeLimit", value: 1)) {
                    context.State = new StateCheckP43(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP43 : TriggerState {
            internal StateCheckP43(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 9110, key: "Box11Check", value: 2);
                context.SetUserValue(triggerID: 9120, key: "Box12Check", value: 5);
                context.SetUserValue(triggerID: 9130, key: "Box13Check", value: 5);
                context.SetUserValue(triggerID: 9140, key: "Box14Check", value: 3);
                context.SetUserValue(triggerID: 9210, key: "Box21Check", value: 4);
                context.SetUserValue(triggerID: 9220, key: "Box22Check", value: 5);
                context.SetUserValue(triggerID: 9230, key: "Box23Check", value: 5);
                context.SetUserValue(triggerID: 9240, key: "Box24Check", value: 4);
                context.SetUserValue(triggerID: 9310, key: "Box31Check", value: 4);
                context.SetUserValue(triggerID: 9320, key: "Box32Check", value: 5);
                context.SetUserValue(triggerID: 9330, key: "Box33Check", value: 5);
                context.SetUserValue(triggerID: 9340, key: "Box34Check", value: 3);
                context.SetUserValue(triggerID: 9410, key: "Box41Check", value: 3);
                context.SetUserValue(triggerID: 9420, key: "Box42Check", value: 2);
                context.SetUserValue(triggerID: 9430, key: "Box43Check", value: 5);
                context.SetUserValue(triggerID: 9440, key: "Box44Check", value: 2);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP43(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP43 : TriggerState {
            internal StateNumberOffP43(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {112}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {125}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {135}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {143}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {214}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {225}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {235}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {244}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {314}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {325}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {335}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {343}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {413}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {422}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {435}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {442}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP43(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP43 : TriggerState {
            internal StateResetP43(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 1, key: "G05P43End", value: 1);
                context.SetUserValue(key: "G05P43Set", value: 0);
                context.SetUserValue(key: "G05P43TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP44 : TriggerState {
            internal StateNumberOnP44(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new int[] {114}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {124}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {133}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {142}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {214}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {224}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {234}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {243}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {313}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {322}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {335}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {345}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {412}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {423}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {435}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {445}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerID: 8110, key: "Barrier11", value: 4);
                context.SetUserValue(triggerID: 8120, key: "Barrier12", value: 4);
                context.SetUserValue(triggerID: 8130, key: "Barrier13", value: 3);
                context.SetUserValue(triggerID: 8140, key: "Barrier14", value: 2);
                context.SetUserValue(triggerID: 8210, key: "Barrier21", value: 4);
                context.SetUserValue(triggerID: 8220, key: "Barrier22", value: 4);
                context.SetUserValue(triggerID: 8230, key: "Barrier23", value: 4);
                context.SetUserValue(triggerID: 8240, key: "Barrier24", value: 3);
                context.SetUserValue(triggerID: 8310, key: "Barrier31", value: 3);
                context.SetUserValue(triggerID: 8320, key: "Barrier32", value: 2);
                context.SetUserValue(triggerID: 8330, key: "Barrier33", value: 5);
                context.SetUserValue(triggerID: 8340, key: "Barrier34", value: 5);
                context.SetUserValue(triggerID: 8410, key: "Barrier41", value: 2);
                context.SetUserValue(triggerID: 8420, key: "Barrier42", value: 3);
                context.SetUserValue(triggerID: 8430, key: "Barrier43", value: 5);
                context.SetUserValue(triggerID: 8440, key: "Barrier44", value: 5);
            }

            public override void Execute() {
                if (context.UserValue(key: "G05P44TimeLimit", value: 1)) {
                    context.State = new StateCheckP44(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP44 : TriggerState {
            internal StateCheckP44(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 9110, key: "Box11Check", value: 4);
                context.SetUserValue(triggerID: 9120, key: "Box12Check", value: 4);
                context.SetUserValue(triggerID: 9130, key: "Box13Check", value: 3);
                context.SetUserValue(triggerID: 9140, key: "Box14Check", value: 2);
                context.SetUserValue(triggerID: 9210, key: "Box21Check", value: 4);
                context.SetUserValue(triggerID: 9220, key: "Box22Check", value: 4);
                context.SetUserValue(triggerID: 9230, key: "Box23Check", value: 4);
                context.SetUserValue(triggerID: 9240, key: "Box24Check", value: 3);
                context.SetUserValue(triggerID: 9310, key: "Box31Check", value: 3);
                context.SetUserValue(triggerID: 9320, key: "Box32Check", value: 2);
                context.SetUserValue(triggerID: 9330, key: "Box33Check", value: 5);
                context.SetUserValue(triggerID: 9340, key: "Box34Check", value: 5);
                context.SetUserValue(triggerID: 9410, key: "Box41Check", value: 2);
                context.SetUserValue(triggerID: 9420, key: "Box42Check", value: 3);
                context.SetUserValue(triggerID: 9430, key: "Box43Check", value: 5);
                context.SetUserValue(triggerID: 9440, key: "Box44Check", value: 5);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP44(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP44 : TriggerState {
            internal StateNumberOffP44(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {114}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {124}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {133}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {142}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {214}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {224}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {234}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {243}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {313}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {322}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {335}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {345}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {412}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {423}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {435}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {445}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP44(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP44 : TriggerState {
            internal StateResetP44(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 1, key: "G05P44End", value: 1);
                context.SetUserValue(key: "G05P44Set", value: 0);
                context.SetUserValue(key: "G05P44TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP45 : TriggerState {
            internal StateNumberOnP45(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new int[] {113}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {124}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {132}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {145}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {215}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {222}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {234}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {244}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {314}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {324}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {333}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {345}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {415}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {423}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {434}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {442}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerID: 8110, key: "Barrier11", value: 3);
                context.SetUserValue(triggerID: 8120, key: "Barrier12", value: 4);
                context.SetUserValue(triggerID: 8130, key: "Barrier13", value: 2);
                context.SetUserValue(triggerID: 8140, key: "Barrier14", value: 5);
                context.SetUserValue(triggerID: 8210, key: "Barrier21", value: 5);
                context.SetUserValue(triggerID: 8220, key: "Barrier22", value: 2);
                context.SetUserValue(triggerID: 8230, key: "Barrier23", value: 4);
                context.SetUserValue(triggerID: 8240, key: "Barrier24", value: 4);
                context.SetUserValue(triggerID: 8310, key: "Barrier31", value: 4);
                context.SetUserValue(triggerID: 8320, key: "Barrier32", value: 4);
                context.SetUserValue(triggerID: 8330, key: "Barrier33", value: 3);
                context.SetUserValue(triggerID: 8340, key: "Barrier34", value: 5);
                context.SetUserValue(triggerID: 8410, key: "Barrier41", value: 5);
                context.SetUserValue(triggerID: 8420, key: "Barrier42", value: 3);
                context.SetUserValue(triggerID: 8430, key: "Barrier43", value: 4);
                context.SetUserValue(triggerID: 8440, key: "Barrier44", value: 2);
            }

            public override void Execute() {
                if (context.UserValue(key: "G05P45TimeLimit", value: 1)) {
                    context.State = new StateCheckP45(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP45 : TriggerState {
            internal StateCheckP45(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 9110, key: "Box11Check", value: 3);
                context.SetUserValue(triggerID: 9120, key: "Box12Check", value: 4);
                context.SetUserValue(triggerID: 9130, key: "Box13Check", value: 2);
                context.SetUserValue(triggerID: 9140, key: "Box14Check", value: 5);
                context.SetUserValue(triggerID: 9210, key: "Box21Check", value: 5);
                context.SetUserValue(triggerID: 9220, key: "Box22Check", value: 2);
                context.SetUserValue(triggerID: 9230, key: "Box23Check", value: 4);
                context.SetUserValue(triggerID: 9240, key: "Box24Check", value: 4);
                context.SetUserValue(triggerID: 9310, key: "Box31Check", value: 4);
                context.SetUserValue(triggerID: 9320, key: "Box32Check", value: 4);
                context.SetUserValue(triggerID: 9330, key: "Box33Check", value: 3);
                context.SetUserValue(triggerID: 9340, key: "Box34Check", value: 5);
                context.SetUserValue(triggerID: 9410, key: "Box41Check", value: 5);
                context.SetUserValue(triggerID: 9420, key: "Box42Check", value: 3);
                context.SetUserValue(triggerID: 9430, key: "Box43Check", value: 4);
                context.SetUserValue(triggerID: 9440, key: "Box44Check", value: 2);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP45(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP45 : TriggerState {
            internal StateNumberOffP45(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {113}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {124}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {132}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {145}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {215}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {222}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {234}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {244}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {314}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {324}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {333}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {345}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {415}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {423}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {434}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {442}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP45(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP45 : TriggerState {
            internal StateResetP45(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 1, key: "G05P45End", value: 1);
                context.SetUserValue(key: "G05P45Set", value: 0);
                context.SetUserValue(key: "G05P45TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP46 : TriggerState {
            internal StateNumberOnP46(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new int[] {114}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {123}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {133}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {145}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {215}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {224}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {235}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {244}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {313}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {325}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {333}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {345}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {414}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {424}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {433}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {443}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerID: 8110, key: "Barrier11", value: 4);
                context.SetUserValue(triggerID: 8120, key: "Barrier12", value: 3);
                context.SetUserValue(triggerID: 8130, key: "Barrier13", value: 3);
                context.SetUserValue(triggerID: 8140, key: "Barrier14", value: 5);
                context.SetUserValue(triggerID: 8210, key: "Barrier21", value: 5);
                context.SetUserValue(triggerID: 8220, key: "Barrier22", value: 4);
                context.SetUserValue(triggerID: 8230, key: "Barrier23", value: 5);
                context.SetUserValue(triggerID: 8240, key: "Barrier24", value: 4);
                context.SetUserValue(triggerID: 8310, key: "Barrier31", value: 3);
                context.SetUserValue(triggerID: 8320, key: "Barrier32", value: 5);
                context.SetUserValue(triggerID: 8330, key: "Barrier33", value: 3);
                context.SetUserValue(triggerID: 8340, key: "Barrier34", value: 5);
                context.SetUserValue(triggerID: 8410, key: "Barrier41", value: 4);
                context.SetUserValue(triggerID: 8420, key: "Barrier42", value: 4);
                context.SetUserValue(triggerID: 8430, key: "Barrier43", value: 3);
                context.SetUserValue(triggerID: 8440, key: "Barrier44", value: 3);
            }

            public override void Execute() {
                if (context.UserValue(key: "G05P46TimeLimit", value: 1)) {
                    context.State = new StateCheckP46(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP46 : TriggerState {
            internal StateCheckP46(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 9110, key: "Box11Check", value: 4);
                context.SetUserValue(triggerID: 9120, key: "Box12Check", value: 3);
                context.SetUserValue(triggerID: 9130, key: "Box13Check", value: 3);
                context.SetUserValue(triggerID: 9140, key: "Box14Check", value: 5);
                context.SetUserValue(triggerID: 9210, key: "Box21Check", value: 5);
                context.SetUserValue(triggerID: 9220, key: "Box22Check", value: 4);
                context.SetUserValue(triggerID: 9230, key: "Box23Check", value: 5);
                context.SetUserValue(triggerID: 9240, key: "Box24Check", value: 4);
                context.SetUserValue(triggerID: 9310, key: "Box31Check", value: 3);
                context.SetUserValue(triggerID: 9320, key: "Box32Check", value: 5);
                context.SetUserValue(triggerID: 9330, key: "Box33Check", value: 3);
                context.SetUserValue(triggerID: 9340, key: "Box34Check", value: 5);
                context.SetUserValue(triggerID: 9410, key: "Box41Check", value: 4);
                context.SetUserValue(triggerID: 9420, key: "Box42Check", value: 4);
                context.SetUserValue(triggerID: 9430, key: "Box43Check", value: 3);
                context.SetUserValue(triggerID: 9440, key: "Box44Check", value: 3);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP46(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP46 : TriggerState {
            internal StateNumberOffP46(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {114}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {123}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {133}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {145}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {215}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {224}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {235}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {244}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {313}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {325}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {333}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {345}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {414}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {424}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {433}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {443}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP46(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP46 : TriggerState {
            internal StateResetP46(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 1, key: "G05P46End", value: 1);
                context.SetUserValue(key: "G05P46Set", value: 0);
                context.SetUserValue(key: "G05P46TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP47 : TriggerState {
            internal StateNumberOnP47(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new int[] {115}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {122}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {135}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {144}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {212}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {222}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {234}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {245}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {312}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {324}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {335}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {342}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {414}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {425}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {434}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {445}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerID: 8110, key: "Barrier11", value: 5);
                context.SetUserValue(triggerID: 8120, key: "Barrier12", value: 2);
                context.SetUserValue(triggerID: 8130, key: "Barrier13", value: 5);
                context.SetUserValue(triggerID: 8140, key: "Barrier14", value: 4);
                context.SetUserValue(triggerID: 8210, key: "Barrier21", value: 2);
                context.SetUserValue(triggerID: 8220, key: "Barrier22", value: 2);
                context.SetUserValue(triggerID: 8230, key: "Barrier23", value: 4);
                context.SetUserValue(triggerID: 8240, key: "Barrier24", value: 5);
                context.SetUserValue(triggerID: 8310, key: "Barrier31", value: 2);
                context.SetUserValue(triggerID: 8320, key: "Barrier32", value: 4);
                context.SetUserValue(triggerID: 8330, key: "Barrier33", value: 5);
                context.SetUserValue(triggerID: 8340, key: "Barrier34", value: 2);
                context.SetUserValue(triggerID: 8410, key: "Barrier41", value: 4);
                context.SetUserValue(triggerID: 8420, key: "Barrier42", value: 5);
                context.SetUserValue(triggerID: 8430, key: "Barrier43", value: 4);
                context.SetUserValue(triggerID: 8440, key: "Barrier44", value: 5);
            }

            public override void Execute() {
                if (context.UserValue(key: "G05P47TimeLimit", value: 1)) {
                    context.State = new StateCheckP47(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP47 : TriggerState {
            internal StateCheckP47(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 9110, key: "Box11Check", value: 5);
                context.SetUserValue(triggerID: 9120, key: "Box12Check", value: 2);
                context.SetUserValue(triggerID: 9130, key: "Box13Check", value: 5);
                context.SetUserValue(triggerID: 9140, key: "Box14Check", value: 4);
                context.SetUserValue(triggerID: 9210, key: "Box21Check", value: 2);
                context.SetUserValue(triggerID: 9220, key: "Box22Check", value: 2);
                context.SetUserValue(triggerID: 9230, key: "Box23Check", value: 4);
                context.SetUserValue(triggerID: 9240, key: "Box24Check", value: 5);
                context.SetUserValue(triggerID: 9310, key: "Box31Check", value: 2);
                context.SetUserValue(triggerID: 9320, key: "Box32Check", value: 4);
                context.SetUserValue(triggerID: 9330, key: "Box33Check", value: 5);
                context.SetUserValue(triggerID: 9340, key: "Box34Check", value: 2);
                context.SetUserValue(triggerID: 9410, key: "Box41Check", value: 4);
                context.SetUserValue(triggerID: 9420, key: "Box42Check", value: 5);
                context.SetUserValue(triggerID: 9430, key: "Box43Check", value: 4);
                context.SetUserValue(triggerID: 9440, key: "Box44Check", value: 5);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP47(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP47 : TriggerState {
            internal StateNumberOffP47(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {115}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {122}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {135}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {144}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {212}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {222}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {234}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {245}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {312}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {324}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {335}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {342}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {414}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {425}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {434}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {445}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP47(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP47 : TriggerState {
            internal StateResetP47(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 1, key: "G05P47End", value: 1);
                context.SetUserValue(key: "G05P47Set", value: 0);
                context.SetUserValue(key: "G05P47TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP48 : TriggerState {
            internal StateNumberOnP48(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new int[] {112}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {125}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {133}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {142}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {215}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {225}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {235}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {245}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {315}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {325}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {335}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {345}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {413}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {422}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {435}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {443}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerID: 8110, key: "Barrier11", value: 2);
                context.SetUserValue(triggerID: 8120, key: "Barrier12", value: 5);
                context.SetUserValue(triggerID: 8130, key: "Barrier13", value: 3);
                context.SetUserValue(triggerID: 8140, key: "Barrier14", value: 2);
                context.SetUserValue(triggerID: 8210, key: "Barrier21", value: 5);
                context.SetUserValue(triggerID: 8220, key: "Barrier22", value: 5);
                context.SetUserValue(triggerID: 8230, key: "Barrier23", value: 5);
                context.SetUserValue(triggerID: 8240, key: "Barrier24", value: 5);
                context.SetUserValue(triggerID: 8310, key: "Barrier31", value: 5);
                context.SetUserValue(triggerID: 8320, key: "Barrier32", value: 5);
                context.SetUserValue(triggerID: 8330, key: "Barrier33", value: 5);
                context.SetUserValue(triggerID: 8340, key: "Barrier34", value: 5);
                context.SetUserValue(triggerID: 8410, key: "Barrier41", value: 3);
                context.SetUserValue(triggerID: 8420, key: "Barrier42", value: 2);
                context.SetUserValue(triggerID: 8430, key: "Barrier43", value: 5);
                context.SetUserValue(triggerID: 8440, key: "Barrier44", value: 3);
            }

            public override void Execute() {
                if (context.UserValue(key: "G05P48TimeLimit", value: 1)) {
                    context.State = new StateCheckP48(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP48 : TriggerState {
            internal StateCheckP48(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 9110, key: "Box11Check", value: 2);
                context.SetUserValue(triggerID: 9120, key: "Box12Check", value: 5);
                context.SetUserValue(triggerID: 9130, key: "Box13Check", value: 3);
                context.SetUserValue(triggerID: 9140, key: "Box14Check", value: 2);
                context.SetUserValue(triggerID: 9210, key: "Box21Check", value: 5);
                context.SetUserValue(triggerID: 9220, key: "Box22Check", value: 5);
                context.SetUserValue(triggerID: 9230, key: "Box23Check", value: 5);
                context.SetUserValue(triggerID: 9240, key: "Box24Check", value: 5);
                context.SetUserValue(triggerID: 9310, key: "Box31Check", value: 5);
                context.SetUserValue(triggerID: 9320, key: "Box32Check", value: 5);
                context.SetUserValue(triggerID: 9330, key: "Box33Check", value: 5);
                context.SetUserValue(triggerID: 9340, key: "Box34Check", value: 5);
                context.SetUserValue(triggerID: 9410, key: "Box41Check", value: 3);
                context.SetUserValue(triggerID: 9420, key: "Box42Check", value: 2);
                context.SetUserValue(triggerID: 9430, key: "Box43Check", value: 5);
                context.SetUserValue(triggerID: 9440, key: "Box44Check", value: 3);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP48(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP48 : TriggerState {
            internal StateNumberOffP48(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {112}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {125}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {133}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {142}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {215}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {225}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {235}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {245}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {315}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {325}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {335}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {345}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {413}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {422}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {435}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {443}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP48(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP48 : TriggerState {
            internal StateResetP48(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 1, key: "G05P48End", value: 1);
                context.SetUserValue(key: "G05P48Set", value: 0);
                context.SetUserValue(key: "G05P48TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP49 : TriggerState {
            internal StateNumberOnP49(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new int[] {113}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {124}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {134}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {142}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {214}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {224}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {233}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {244}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {314}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {322}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {334}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {344}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {413}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {424}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {434}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {442}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerID: 8110, key: "Barrier11", value: 3);
                context.SetUserValue(triggerID: 8120, key: "Barrier12", value: 4);
                context.SetUserValue(triggerID: 8130, key: "Barrier13", value: 4);
                context.SetUserValue(triggerID: 8140, key: "Barrier14", value: 2);
                context.SetUserValue(triggerID: 8210, key: "Barrier21", value: 4);
                context.SetUserValue(triggerID: 8220, key: "Barrier22", value: 4);
                context.SetUserValue(triggerID: 8230, key: "Barrier23", value: 3);
                context.SetUserValue(triggerID: 8240, key: "Barrier24", value: 4);
                context.SetUserValue(triggerID: 8310, key: "Barrier31", value: 4);
                context.SetUserValue(triggerID: 8320, key: "Barrier32", value: 2);
                context.SetUserValue(triggerID: 8330, key: "Barrier33", value: 4);
                context.SetUserValue(triggerID: 8340, key: "Barrier34", value: 4);
                context.SetUserValue(triggerID: 8410, key: "Barrier41", value: 3);
                context.SetUserValue(triggerID: 8420, key: "Barrier42", value: 4);
                context.SetUserValue(triggerID: 8430, key: "Barrier43", value: 4);
                context.SetUserValue(triggerID: 8440, key: "Barrier44", value: 2);
            }

            public override void Execute() {
                if (context.UserValue(key: "G05P49TimeLimit", value: 1)) {
                    context.State = new StateCheckP49(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP49 : TriggerState {
            internal StateCheckP49(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 9110, key: "Box11Check", value: 3);
                context.SetUserValue(triggerID: 9120, key: "Box12Check", value: 4);
                context.SetUserValue(triggerID: 9130, key: "Box13Check", value: 4);
                context.SetUserValue(triggerID: 9140, key: "Box14Check", value: 2);
                context.SetUserValue(triggerID: 9210, key: "Box21Check", value: 4);
                context.SetUserValue(triggerID: 9220, key: "Box22Check", value: 4);
                context.SetUserValue(triggerID: 9230, key: "Box23Check", value: 3);
                context.SetUserValue(triggerID: 9240, key: "Box24Check", value: 4);
                context.SetUserValue(triggerID: 9310, key: "Box31Check", value: 4);
                context.SetUserValue(triggerID: 9320, key: "Box32Check", value: 2);
                context.SetUserValue(triggerID: 9330, key: "Box33Check", value: 4);
                context.SetUserValue(triggerID: 9340, key: "Box34Check", value: 4);
                context.SetUserValue(triggerID: 9410, key: "Box41Check", value: 3);
                context.SetUserValue(triggerID: 9420, key: "Box42Check", value: 4);
                context.SetUserValue(triggerID: 9430, key: "Box43Check", value: 4);
                context.SetUserValue(triggerID: 9440, key: "Box44Check", value: 2);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP49(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP49 : TriggerState {
            internal StateNumberOffP49(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {113}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {124}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {134}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {142}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {214}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {224}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {233}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {244}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {314}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {322}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {334}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {344}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {413}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {424}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {434}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {442}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP49(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP49 : TriggerState {
            internal StateResetP49(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 1, key: "G05P49End", value: 1);
                context.SetUserValue(key: "G05P49Set", value: 0);
                context.SetUserValue(key: "G05P49TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP50 : TriggerState {
            internal StateNumberOnP50(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new int[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new int[] {114}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {123}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {132}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {144}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {213}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {224}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {234}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {242}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {312}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {324}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {334}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {343}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {414}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {425}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {435}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {444}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerID: 8110, key: "Barrier11", value: 4);
                context.SetUserValue(triggerID: 8120, key: "Barrier12", value: 3);
                context.SetUserValue(triggerID: 8130, key: "Barrier13", value: 2);
                context.SetUserValue(triggerID: 8140, key: "Barrier14", value: 4);
                context.SetUserValue(triggerID: 8210, key: "Barrier21", value: 3);
                context.SetUserValue(triggerID: 8220, key: "Barrier22", value: 4);
                context.SetUserValue(triggerID: 8230, key: "Barrier23", value: 4);
                context.SetUserValue(triggerID: 8240, key: "Barrier24", value: 2);
                context.SetUserValue(triggerID: 8310, key: "Barrier31", value: 2);
                context.SetUserValue(triggerID: 8320, key: "Barrier32", value: 4);
                context.SetUserValue(triggerID: 8330, key: "Barrier33", value: 4);
                context.SetUserValue(triggerID: 8340, key: "Barrier34", value: 3);
                context.SetUserValue(triggerID: 8410, key: "Barrier41", value: 4);
                context.SetUserValue(triggerID: 8420, key: "Barrier42", value: 5);
                context.SetUserValue(triggerID: 8430, key: "Barrier43", value: 5);
                context.SetUserValue(triggerID: 8440, key: "Barrier44", value: 4);
            }

            public override void Execute() {
                if (context.UserValue(key: "G05P50TimeLimit", value: 1)) {
                    context.State = new StateCheckP50(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP50 : TriggerState {
            internal StateCheckP50(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 9110, key: "Box11Check", value: 4);
                context.SetUserValue(triggerID: 9120, key: "Box12Check", value: 3);
                context.SetUserValue(triggerID: 9130, key: "Box13Check", value: 2);
                context.SetUserValue(triggerID: 9140, key: "Box14Check", value: 4);
                context.SetUserValue(triggerID: 9210, key: "Box21Check", value: 3);
                context.SetUserValue(triggerID: 9220, key: "Box22Check", value: 4);
                context.SetUserValue(triggerID: 9230, key: "Box23Check", value: 4);
                context.SetUserValue(triggerID: 9240, key: "Box24Check", value: 2);
                context.SetUserValue(triggerID: 9310, key: "Box31Check", value: 2);
                context.SetUserValue(triggerID: 9320, key: "Box32Check", value: 4);
                context.SetUserValue(triggerID: 9330, key: "Box33Check", value: 4);
                context.SetUserValue(triggerID: 9340, key: "Box34Check", value: 3);
                context.SetUserValue(triggerID: 9410, key: "Box41Check", value: 4);
                context.SetUserValue(triggerID: 9420, key: "Box42Check", value: 5);
                context.SetUserValue(triggerID: 9430, key: "Box43Check", value: 5);
                context.SetUserValue(triggerID: 9440, key: "Box44Check", value: 4);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP50(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP50 : TriggerState {
            internal StateNumberOffP50(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {114}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {123}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {132}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {144}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {213}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {224}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {234}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {242}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {312}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {324}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {334}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {343}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {414}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {425}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {435}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {444}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP50(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP50 : TriggerState {
            internal StateResetP50(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 1, key: "G05P50End", value: 1);
                context.SetUserValue(key: "G05P50Set", value: 0);
                context.SetUserValue(key: "G05P50TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}