namespace Maple2.Trigger._61000008_me {
    public static class _g06p00_600 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {110, 111, 112, 113, 114, 115}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetMesh(arg1: new[] {120, 121, 122, 123, 124, 125}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetMesh(arg1: new[] {130, 131, 132, 133, 134, 135}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetMesh(arg1: new[] {140, 141, 142, 143, 144, 145}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetMesh(arg1: new[] {210, 211, 212, 213, 214, 215}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetMesh(arg1: new[] {220, 221, 222, 223, 224, 225}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetMesh(arg1: new[] {230, 231, 232, 233, 234, 235}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetMesh(arg1: new[] {240, 241, 242, 243, 244, 245}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetMesh(arg1: new[] {310, 311, 312, 313, 314, 315}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetMesh(arg1: new[] {320, 321, 322, 323, 324, 325}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetMesh(arg1: new[] {330, 331, 332, 333, 334, 335}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetMesh(arg1: new[] {340, 341, 342, 343, 344, 345}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetMesh(arg1: new[] {410, 411, 412, 413, 414, 415}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetMesh(arg1: new[] {420, 421, 422, 423, 424, 425}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetMesh(arg1: new[] {430, 431, 432, 433, 434, 435}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetMesh(arg1: new[] {440, 441, 442, 443, 444, 445}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetMesh(arg1: new[] {2207, 2208, 2209, 22000, 22005, 22010, 22020, 22030}, arg2: false,
                    arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {2307, 2308, 2309, 23000, 23005, 23010, 23020, 23030}, arg2: false,
                    arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3207, 3208, 3209, 32000, 32005, 32010, 32020, 32030}, arg2: false,
                    arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3307, 3308, 3309, 33000, 33005, 33010, 33020, 33030}, arg2: false,
                    arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "G06P101Set") == 1) {
                    context.State = new StateNumberOnP101(context);
                    return;
                }

                if (context.GetUserValue(key: "G06P102Set") == 1) {
                    context.State = new StateNumberOnP102(context);
                    return;
                }

                if (context.GetUserValue(key: "G06P103Set") == 1) {
                    context.State = new StateNumberOnP103(context);
                    return;
                }

                if (context.GetUserValue(key: "G06P104Set") == 1) {
                    context.State = new StateNumberOnP104(context);
                    return;
                }

                if (context.GetUserValue(key: "G06P105Set") == 1) {
                    context.State = new StateNumberOnP105(context);
                    return;
                }

                if (context.GetUserValue(key: "G06P106Set") == 1) {
                    context.State = new StateNumberOnP106(context);
                    return;
                }

                if (context.GetUserValue(key: "G06P107Set") == 1) {
                    context.State = new StateNumberOnP107(context);
                    return;
                }

                if (context.GetUserValue(key: "G06P108Set") == 1) {
                    context.State = new StateNumberOnP108(context);
                    return;
                }

                if (context.GetUserValue(key: "G06P109Set") == 1) {
                    context.State = new StateNumberOnP109(context);
                    return;
                }

                if (context.GetUserValue(key: "G06P110Set") == 1) {
                    context.State = new StateNumberOnP110(context);
                    return;
                }

                if (context.GetUserValue(key: "G06P201Set") == 1) {
                    context.State = new StateNumberOnP201(context);
                    return;
                }

                if (context.GetUserValue(key: "G06P202Set") == 1) {
                    context.State = new StateNumberOnP202(context);
                    return;
                }

                if (context.GetUserValue(key: "G06P203Set") == 1) {
                    context.State = new StateNumberOnP203(context);
                    return;
                }

                if (context.GetUserValue(key: "G06P204Set") == 1) {
                    context.State = new StateNumberOnP204(context);
                    return;
                }

                if (context.GetUserValue(key: "G06P205Set") == 1) {
                    context.State = new StateNumberOnP205(context);
                    return;
                }

                if (context.GetUserValue(key: "G06P206Set") == 1) {
                    context.State = new StateNumberOnP206(context);
                    return;
                }

                if (context.GetUserValue(key: "G06P207Set") == 1) {
                    context.State = new StateNumberOnP207(context);
                    return;
                }

                if (context.GetUserValue(key: "G06P208Set") == 1) {
                    context.State = new StateNumberOnP208(context);
                    return;
                }

                if (context.GetUserValue(key: "G06P209Set") == 1) {
                    context.State = new StateNumberOnP209(context);
                    return;
                }

                if (context.GetUserValue(key: "G06P210Set") == 1) {
                    context.State = new StateNumberOnP210(context);
                    return;
                }

                if (context.GetUserValue(key: "G06P211Set") == 1) {
                    context.State = new StateNumberOnP211(context);
                    return;
                }

                if (context.GetUserValue(key: "G06P212Set") == 1) {
                    context.State = new StateNumberOnP212(context);
                    return;
                }

                if (context.GetUserValue(key: "G06P213Set") == 1) {
                    context.State = new StateNumberOnP213(context);
                    return;
                }

                if (context.GetUserValue(key: "G06P214Set") == 1) {
                    context.State = new StateNumberOnP214(context);
                    return;
                }

                if (context.GetUserValue(key: "G06P215Set") == 1) {
                    context.State = new StateNumberOnP215(context);
                    return;
                }

                if (context.GetUserValue(key: "G06P216Set") == 1) {
                    context.State = new StateNumberOnP216(context);
                    return;
                }

                if (context.GetUserValue(key: "G06P217Set") == 1) {
                    context.State = new StateNumberOnP217(context);
                    return;
                }

                if (context.GetUserValue(key: "G06P218Set") == 1) {
                    context.State = new StateNumberOnP218(context);
                    return;
                }

                if (context.GetUserValue(key: "G06P219Set") == 1) {
                    context.State = new StateNumberOnP219(context);
                    return;
                }

                if (context.GetUserValue(key: "G06P220Set") == 1) {
                    context.State = new StateNumberOnP220(context);
                    return;
                }

                if (context.GetUserValue(key: "G06P301Set") == 1) {
                    context.State = new StateNumberOnP301(context);
                    return;
                }

                if (context.GetUserValue(key: "G06P302Set") == 1) {
                    context.State = new StateNumberOnP302(context);
                    return;
                }

                if (context.GetUserValue(key: "G06P303Set") == 1) {
                    context.State = new StateNumberOnP303(context);
                    return;
                }

                if (context.GetUserValue(key: "G06P304Set") == 1) {
                    context.State = new StateNumberOnP304(context);
                    return;
                }

                if (context.GetUserValue(key: "G06P305Set") == 1) {
                    context.State = new StateNumberOnP305(context);
                    return;
                }

                if (context.GetUserValue(key: "G06P306Set") == 1) {
                    context.State = new StateNumberOnP306(context);
                    return;
                }

                if (context.GetUserValue(key: "G06P307Set") == 1) {
                    context.State = new StateNumberOnP307(context);
                    return;
                }

                if (context.GetUserValue(key: "G06P308Set") == 1) {
                    context.State = new StateNumberOnP308(context);
                    return;
                }

                if (context.GetUserValue(key: "G06P309Set") == 1) {
                    context.State = new StateNumberOnP309(context);
                    return;
                }

                if (context.GetUserValue(key: "G06P310Set") == 1) {
                    context.State = new StateNumberOnP310(context);
                    return;
                }

                if (context.GetUserValue(key: "G06P311Set") == 1) {
                    context.State = new StateNumberOnP311(context);
                    return;
                }

                if (context.GetUserValue(key: "G06P312Set") == 1) {
                    context.State = new StateNumberOnP312(context);
                    return;
                }

                if (context.GetUserValue(key: "G06P313Set") == 1) {
                    context.State = new StateNumberOnP313(context);
                    return;
                }

                if (context.GetUserValue(key: "G06P314Set") == 1) {
                    context.State = new StateNumberOnP314(context);
                    return;
                }

                if (context.GetUserValue(key: "G06P315Set") == 1) {
                    context.State = new StateNumberOnP315(context);
                    return;
                }

                if (context.GetUserValue(key: "G06P316Set") == 1) {
                    context.State = new StateNumberOnP316(context);
                    return;
                }

                if (context.GetUserValue(key: "G06P317Set") == 1) {
                    context.State = new StateNumberOnP317(context);
                    return;
                }

                if (context.GetUserValue(key: "G06P318Set") == 1) {
                    context.State = new StateNumberOnP318(context);
                    return;
                }

                if (context.GetUserValue(key: "G06P319Set") == 1) {
                    context.State = new StateNumberOnP319(context);
                    return;
                }

                if (context.GetUserValue(key: "G06P320Set") == 1) {
                    context.State = new StateNumberOnP320(context);
                    return;
                }

                if (context.GetUserValue(key: "G06P401Set") == 1) {
                    context.State = new StateNumberOnP401(context);
                    return;
                }

                if (context.GetUserValue(key: "G06P402Set") == 1) {
                    context.State = new StateNumberOnP402(context);
                    return;
                }

                if (context.GetUserValue(key: "G06P403Set") == 1) {
                    context.State = new StateNumberOnP403(context);
                    return;
                }

                if (context.GetUserValue(key: "G06P404Set") == 1) {
                    context.State = new StateNumberOnP404(context);
                    return;
                }

                if (context.GetUserValue(key: "G06P405Set") == 1) {
                    context.State = new StateNumberOnP405(context);
                    return;
                }

                if (context.GetUserValue(key: "G06P406Set") == 1) {
                    context.State = new StateNumberOnP406(context);
                    return;
                }

                if (context.GetUserValue(key: "G06P407Set") == 1) {
                    context.State = new StateNumberOnP407(context);
                    return;
                }

                if (context.GetUserValue(key: "G06P408Set") == 1) {
                    context.State = new StateNumberOnP408(context);
                    return;
                }

                if (context.GetUserValue(key: "G06P409Set") == 1) {
                    context.State = new StateNumberOnP409(context);
                    return;
                }

                if (context.GetUserValue(key: "G06P410Set") == 1) {
                    context.State = new StateNumberOnP410(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP101 : TriggerState {
            internal StateNumberOnP101(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7110, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7120, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7130, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7140, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7210, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7220, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7230, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7240, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7310, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7320, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7330, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7340, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7410, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7420, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7430, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7440, key: "ColorStart", value: 1);
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new[] {111}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {121}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {132}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {141}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {212}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {222}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {2307}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {241}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {311}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {321}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {332}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {342}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {411}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {422}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {431}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {441}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 1);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 1);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 2);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 1);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 2);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 2);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 7);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 1);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 1);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 1);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 2);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 2);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 1);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 2);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 1);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 1);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "G06P101TimeLimit") == 1) {
                    context.State = new StateCheckP101(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP101 : TriggerState {
            internal StateCheckP101(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 1);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 1);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 2);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 1);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 2);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 2);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 7);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 1);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 1);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 1);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 2);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 2);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 1);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 2);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 1);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 1);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP101(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP101 : TriggerState {
            internal StateNumberOffP101(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {111}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {121}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {132}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {141}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {212}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {222}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {2307}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {241}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {311}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {321}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {332}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {342}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {411}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {422}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {431}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {441}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP101(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP101 : TriggerState {
            internal StateResetP101(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G06P101End", value: 1);
                context.SetUserValue(key: "G06P101Set", value: 0);
                context.SetUserValue(key: "G06P101TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP102 : TriggerState {
            internal StateNumberOnP102(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7110, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7120, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7130, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7140, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7210, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7220, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7230, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7240, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7310, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7320, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7330, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7340, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7410, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7420, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7430, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7440, key: "ColorStart", value: 1);
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new[] {112}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {120}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {132}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {142}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {212}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {221}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {232}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {242}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {312}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {3207}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {330}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {341}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {412}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {420}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {431}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {442}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 2);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 0);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 2);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 2);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 2);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 1);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 2);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 2);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 2);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 7);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 0);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 1);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 2);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 0);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 1);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 2);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "G06P102TimeLimit") == 1) {
                    context.State = new StateCheckP102(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP102 : TriggerState {
            internal StateCheckP102(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 2);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 0);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 2);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 2);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 2);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 1);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 2);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 2);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 2);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 7);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 0);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 1);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 2);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 0);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 1);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 2);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP102(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP102 : TriggerState {
            internal StateNumberOffP102(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {112}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {120}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {132}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {142}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {212}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {221}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {232}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {242}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {312}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {3207}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {330}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {341}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {412}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {420}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {431}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {442}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP102(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP102 : TriggerState {
            internal StateResetP102(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G06P102End", value: 1);
                context.SetUserValue(key: "G06P102Set", value: 0);
                context.SetUserValue(key: "G06P102TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP103 : TriggerState {
            internal StateNumberOnP103(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7110, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7120, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7130, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7140, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7210, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7220, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7230, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7240, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7310, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7320, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7330, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7340, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7410, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7420, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7430, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7440, key: "ColorStart", value: 1);
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new[] {110}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {123}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {132}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {140}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {212}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {221}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {233}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {245}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {310}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {325}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {3307}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {343}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {410}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {422}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {430}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {441}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 0);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 3);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 2);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 0);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 2);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 1);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 3);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 5);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 0);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 5);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 7);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 3);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 0);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 2);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 0);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 1);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "G06P103TimeLimit") == 1) {
                    context.State = new StateCheckP103(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP103 : TriggerState {
            internal StateCheckP103(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 0);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 3);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 2);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 0);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 2);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 1);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 3);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 5);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 0);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 5);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 7);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 3);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 0);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 2);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 0);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 1);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP103(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP103 : TriggerState {
            internal StateNumberOffP103(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {110}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {123}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {132}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {140}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {212}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {221}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {233}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {245}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {310}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {325}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {3307}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {343}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {410}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {422}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {430}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {441}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP103(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP103 : TriggerState {
            internal StateResetP103(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G06P103End", value: 1);
                context.SetUserValue(key: "G06P103Set", value: 0);
                context.SetUserValue(key: "G06P103TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP104 : TriggerState {
            internal StateNumberOnP104(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7110, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7120, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7130, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7140, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7210, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7220, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7230, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7240, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7310, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7320, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7330, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7340, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7410, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7420, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7430, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7440, key: "ColorStart", value: 1);
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new[] {111}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {121}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {133}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {140}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {210}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {223}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {230}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {243}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {311}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {3208}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {331}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {340}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {413}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {421}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {430}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {443}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 1);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 1);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 3);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 0);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 0);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 3);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 0);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 3);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 1);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 8);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 1);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 0);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 3);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 1);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 0);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 3);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "G06P104TimeLimit") == 1) {
                    context.State = new StateCheckP104(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP104 : TriggerState {
            internal StateCheckP104(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 1);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 1);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 3);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 0);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 0);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 3);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 0);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 3);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 1);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 8);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 1);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 0);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 3);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 1);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 0);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 3);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP104(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP104 : TriggerState {
            internal StateNumberOffP104(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {111}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {121}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {133}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {140}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {210}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {223}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {230}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {243}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {311}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {3208}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {331}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {340}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {413}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {421}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {430}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {443}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP104(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP104 : TriggerState {
            internal StateResetP104(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G06P104End", value: 1);
                context.SetUserValue(key: "G06P104Set", value: 0);
                context.SetUserValue(key: "G06P104TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP105 : TriggerState {
            internal StateNumberOnP105(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7110, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7120, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7130, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7140, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7210, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7220, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7230, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7240, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7310, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7320, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7330, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7340, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7410, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7420, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7430, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7440, key: "ColorStart", value: 1);
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new[] {110}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {123}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {132}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {144}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {210}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {222}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {2308}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {243}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {310}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {323}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {332}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {342}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {410}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {424}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {433}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {440}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 0);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 3);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 2);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 4);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 0);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 2);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 8);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 3);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 0);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 3);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 2);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 2);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 0);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 4);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 3);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 0);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "G06P105TimeLimit") == 1) {
                    context.State = new StateCheckP105(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP105 : TriggerState {
            internal StateCheckP105(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 0);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 3);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 2);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 4);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 0);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 2);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 8);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 3);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 0);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 3);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 2);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 2);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 0);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 4);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 3);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 0);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP105(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP105 : TriggerState {
            internal StateNumberOffP105(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {110}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {123}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {132}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {144}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {210}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {222}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {2308}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {243}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {310}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {323}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {332}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {342}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {410}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {424}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {433}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {440}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP105(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP105 : TriggerState {
            internal StateResetP105(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G06P105End", value: 1);
                context.SetUserValue(key: "G06P105Set", value: 0);
                context.SetUserValue(key: "G06P105TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP106 : TriggerState {
            internal StateNumberOnP106(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7110, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7120, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7130, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7140, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7210, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7220, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7230, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7240, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7310, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7320, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7330, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7340, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7410, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7420, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7430, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7440, key: "ColorStart", value: 1);
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new[] {112}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {120}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {132}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {140}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {213}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {2208}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {235}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {243}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {310}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {325}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {333}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {340}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {413}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {420}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {430}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {442}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 2);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 0);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 2);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 0);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 3);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 8);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 5);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 3);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 0);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 5);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 3);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 0);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 3);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 0);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 0);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 2);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "G06P106TimeLimit") == 1) {
                    context.State = new StateCheckP106(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP106 : TriggerState {
            internal StateCheckP106(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 2);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 0);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 2);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 0);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 3);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 8);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 5);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 3);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 0);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 5);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 3);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 0);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 3);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 0);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 0);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 2);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP106(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP106 : TriggerState {
            internal StateNumberOffP106(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {112}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {120}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {132}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {140}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {213}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {2208}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {235}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {243}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {310}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {325}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {333}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {340}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {413}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {420}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {430}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {442}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP106(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP106 : TriggerState {
            internal StateResetP106(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G06P106End", value: 1);
                context.SetUserValue(key: "G06P106Set", value: 0);
                context.SetUserValue(key: "G06P106TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP107 : TriggerState {
            internal StateNumberOnP107(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7110, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7120, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7130, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7140, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7210, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7220, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7230, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7240, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7310, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7320, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7330, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7340, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7410, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7420, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7430, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7440, key: "ColorStart", value: 1);
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new[] {113}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {123}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {130}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {142}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {210}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {223}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {2309}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {242}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {310}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {323}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {332}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {342}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {413}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {420}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {432}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {440}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 3);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 3);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 0);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 2);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 0);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 3);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 9);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 2);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 0);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 3);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 2);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 2);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 3);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 0);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 2);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 0);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "G06P107TimeLimit") == 1) {
                    context.State = new StateCheckP107(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP107 : TriggerState {
            internal StateCheckP107(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 3);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 3);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 0);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 2);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 0);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 3);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 9);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 2);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 0);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 3);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 2);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 2);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 3);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 0);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 2);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 0);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP107(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP107 : TriggerState {
            internal StateNumberOffP107(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {113}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {123}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {130}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {142}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {210}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {223}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {2309}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {242}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {310}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {323}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {332}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {342}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {413}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {420}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {432}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {440}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP107(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP107 : TriggerState {
            internal StateResetP107(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G06P107End", value: 1);
                context.SetUserValue(key: "G06P107Set", value: 0);
                context.SetUserValue(key: "G06P107TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP108 : TriggerState {
            internal StateNumberOnP108(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7110, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7120, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7130, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7140, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7210, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7220, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7230, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7240, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7310, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7320, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7330, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7340, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7410, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7420, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7430, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7440, key: "ColorStart", value: 1);
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new[] {110}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {122}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {133}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {140}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {213}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {221}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {232}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {241}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {311}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {3209}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {333}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {343}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {411}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {422}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {430}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {442}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 0);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 2);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 3);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 0);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 3);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 1);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 2);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 1);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 1);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 9);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 3);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 3);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 1);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 2);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 0);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 2);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "G06P108TimeLimit") == 1) {
                    context.State = new StateCheckP108(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP108 : TriggerState {
            internal StateCheckP108(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 0);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 2);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 3);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 0);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 3);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 1);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 2);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 1);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 1);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 9);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 3);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 3);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 1);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 2);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 0);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 2);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP108(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP108 : TriggerState {
            internal StateNumberOffP108(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {110}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {122}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {133}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {140}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {213}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {221}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {232}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {241}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {311}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {3209}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {333}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {343}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {411}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {422}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {430}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {442}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP108(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP108 : TriggerState {
            internal StateResetP108(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G06P108End", value: 1);
                context.SetUserValue(key: "G06P108Set", value: 0);
                context.SetUserValue(key: "G06P108TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP109 : TriggerState {
            internal StateNumberOnP109(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7110, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7120, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7130, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7140, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7210, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7220, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7230, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7240, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7310, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7320, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7330, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7340, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7410, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7420, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7430, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7440, key: "ColorStart", value: 1);
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new[] {110}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {123}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {130}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {143}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {210}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {225}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {231}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {243}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {310}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {321}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {3309}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {342}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {412}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {420}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {434}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {441}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 0);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 3);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 0);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 3);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 0);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 5);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 1);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 3);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 0);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 1);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 9);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 2);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 2);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 0);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 4);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 1);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "G06P109TimeLimit") == 1) {
                    context.State = new StateCheckP109(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP109 : TriggerState {
            internal StateCheckP109(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 0);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 3);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 0);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 3);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 0);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 5);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 1);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 3);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 0);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 1);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 9);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 2);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 2);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 0);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 4);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 1);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP109(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP109 : TriggerState {
            internal StateNumberOffP109(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {110}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {123}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {130}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {143}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {210}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {225}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {231}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {243}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {310}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {321}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {3309}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {342}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {412}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {420}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {434}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {441}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP109(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP109 : TriggerState {
            internal StateResetP109(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G06P109End", value: 1);
                context.SetUserValue(key: "G06P109Set", value: 0);
                context.SetUserValue(key: "G06P109TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP110 : TriggerState {
            internal StateNumberOnP110(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7110, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7120, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7130, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7140, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7210, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7220, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7230, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7240, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7310, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7320, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7330, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7340, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7410, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7420, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7430, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7440, key: "ColorStart", value: 1);
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new[] {110}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {123}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {130}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {145}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {214}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {221}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {23010}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {23000}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {240}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {310}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {321}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {334}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {341}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {415}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {420}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {432}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {440}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 0);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 3);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 0);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 5);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 4);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 1);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 6);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 0);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 0);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 1);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 4);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 1);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 5);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 0);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 2);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 0);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "G06P110TimeLimit") == 1) {
                    context.State = new StateCheckP110(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP110 : TriggerState {
            internal StateCheckP110(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 0);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 3);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 0);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 5);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 4);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 1);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 6);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 0);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 0);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 1);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 4);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 1);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 5);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 0);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 2);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 0);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP110(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP110 : TriggerState {
            internal StateNumberOffP110(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {110}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {123}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {130}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {145}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {214}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {221}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {23010}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {23000}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {240}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {310}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {321}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {334}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {341}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {415}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {420}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {432}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {440}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP110(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP110 : TriggerState {
            internal StateResetP110(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G06P110End", value: 1);
                context.SetUserValue(key: "G06P110Set", value: 0);
                context.SetUserValue(key: "G06P110TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP201 : TriggerState {
            internal StateNumberOnP201(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7110, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7120, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7130, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7140, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7210, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7220, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7230, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7240, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7310, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7320, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7330, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7340, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7410, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7420, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7430, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7440, key: "ColorStart", value: 1);
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new[] {112}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {124}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {133}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {140}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {213}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {2207}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {232}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {240}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {310}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {323}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {33010}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {33000}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {342}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {415}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {420}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {434}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {443}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 2);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 4);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 3);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 0);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 3);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 7);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 2);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 0);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 0);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 3);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 6);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 2);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 5);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 0);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 4);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 3);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "G06P201TimeLimit") == 1) {
                    context.State = new StateCheckP201(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP201 : TriggerState {
            internal StateCheckP201(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 2);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 4);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 3);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 0);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 3);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 7);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 2);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 0);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 0);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 3);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 6);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 2);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 5);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 0);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 4);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 3);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP201(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP201 : TriggerState {
            internal StateNumberOffP201(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {112}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {124}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {133}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {140}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {213}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {2207}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {232}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {240}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {310}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {323}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {33010}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {33000}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {342}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {415}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {420}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {434}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {443}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP201(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP201 : TriggerState {
            internal StateResetP201(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G06P201End", value: 1);
                context.SetUserValue(key: "G06P201Set", value: 0);
                context.SetUserValue(key: "G06P201TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP202 : TriggerState {
            internal StateNumberOnP202(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7110, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7120, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7130, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7140, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7210, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7220, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7230, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7240, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7310, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7320, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7330, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7340, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7410, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7420, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7430, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7440, key: "ColorStart", value: 1);
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new[] {113}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {122}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {130}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {142}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {213}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {223}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {2309}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {242}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {313}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {3208}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {333}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {343}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {412}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {423}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {432}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {440}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 3);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 2);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 0);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 2);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 3);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 3);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 9);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 2);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 3);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 8);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 3);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 3);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 2);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 3);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 2);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 0);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "G06P202TimeLimit") == 1) {
                    context.State = new StateCheckP202(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP202 : TriggerState {
            internal StateCheckP202(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 3);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 2);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 0);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 2);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 3);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 3);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 9);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 2);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 3);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 8);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 3);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 3);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 2);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 3);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 2);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 0);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP202(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP202 : TriggerState {
            internal StateNumberOffP202(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {113}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {122}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {130}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {142}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {213}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {223}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {2309}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {242}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {313}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {3208}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {333}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {343}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {412}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {423}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {432}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {440}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP202(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP202 : TriggerState {
            internal StateResetP202(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G06P202End", value: 1);
                context.SetUserValue(key: "G06P202Set", value: 0);
                context.SetUserValue(key: "G06P202TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP203 : TriggerState {
            internal StateNumberOnP203(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7110, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7120, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7130, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7140, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7210, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7220, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7230, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7240, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7310, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7320, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7330, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7340, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7410, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7420, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7430, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7440, key: "ColorStart", value: 1);
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new[] {114}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {123}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {130}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {145}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {213}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {2208}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {2308}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {242}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {310}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {323}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {332}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {343}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {410}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {422}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {432}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {444}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 4);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 3);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 0);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 5);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 3);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 8);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 8);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 2);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 0);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 3);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 2);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 3);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 0);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 2);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 2);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 4);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "G06P203TimeLimit") == 1) {
                    context.State = new StateCheckP203(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP203 : TriggerState {
            internal StateCheckP203(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 4);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 3);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 0);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 5);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 3);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 8);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 8);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 2);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 0);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 3);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 2);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 3);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 0);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 2);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 2);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 4);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP203(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP203 : TriggerState {
            internal StateNumberOffP203(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {114}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {123}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {130}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {145}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {213}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {2208}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {2308}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {242}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {310}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {323}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {332}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {343}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {410}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {422}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {432}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {444}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP203(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP203 : TriggerState {
            internal StateResetP203(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G06P203End", value: 1);
                context.SetUserValue(key: "G06P203Set", value: 0);
                context.SetUserValue(key: "G06P203TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP204 : TriggerState {
            internal StateNumberOnP204(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7110, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7120, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7130, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7140, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7210, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7220, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7230, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7240, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7310, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7320, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7330, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7340, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7410, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7420, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7430, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7440, key: "ColorStart", value: 1);
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new[] {110}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {124}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {133}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {140}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {213}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {22010}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {22000}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {232}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {244}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {312}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {3209}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {333}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {340}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {412}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {424}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {430}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {443}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 0);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 4);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 3);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 0);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 3);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 6);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 2);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 4);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 2);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 9);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 3);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 0);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 2);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 4);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 0);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 3);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "G06P204TimeLimit") == 1) {
                    context.State = new StateCheckP204(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP204 : TriggerState {
            internal StateCheckP204(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 0);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 4);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 3);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 0);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 3);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 6);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 2);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 4);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 2);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 9);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 3);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 0);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 2);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 4);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 0);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 3);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP204(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP204 : TriggerState {
            internal StateNumberOffP204(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {110}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {124}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {133}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {140}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {213}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {22010}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {22000}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {232}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {244}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {312}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {3209}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {333}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {340}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {412}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {424}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {430}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {443}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP204(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP204 : TriggerState {
            internal StateResetP204(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G06P204End", value: 1);
                context.SetUserValue(key: "G06P204Set", value: 0);
                context.SetUserValue(key: "G06P204TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP205 : TriggerState {
            internal StateNumberOnP205(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7110, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7120, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7130, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7140, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7210, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7220, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7230, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7240, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7310, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7320, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7330, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7340, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7410, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7420, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7430, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7440, key: "ColorStart", value: 1);
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new[] {113}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {120}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {133}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {140}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {214}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {222}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {233}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {243}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {310}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {32010}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {32000}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {3308}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {342}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {412}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {423}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {433}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {444}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 3);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 0);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 3);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 0);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 4);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 2);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 3);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 3);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 0);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 6);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 8);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 2);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 2);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 3);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 3);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 4);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "G06P205TimeLimit") == 1) {
                    context.State = new StateCheckP205(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP205 : TriggerState {
            internal StateCheckP205(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 3);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 0);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 3);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 0);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 4);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 2);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 3);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 3);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 0);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 6);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 8);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 2);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 2);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 3);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 3);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 4);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP205(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP205 : TriggerState {
            internal StateNumberOffP205(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {113}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {120}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {133}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {140}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {214}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {222}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {233}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {243}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {310}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {32010}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {32000}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {3308}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {342}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {412}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {423}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {433}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {444}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP205(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP205 : TriggerState {
            internal StateResetP205(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G06P205End", value: 1);
                context.SetUserValue(key: "G06P205Set", value: 0);
                context.SetUserValue(key: "G06P205TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP206 : TriggerState {
            internal StateNumberOnP206(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7110, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7120, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7130, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7140, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7210, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7220, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7230, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7240, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7310, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7320, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7330, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7340, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7410, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7420, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7430, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7440, key: "ColorStart", value: 1);
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new[] {110}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {120}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {133}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {143}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {210}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {225}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {2309}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {242}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {313}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {3207}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {335}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {343}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {414}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {422}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {430}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {440}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 0);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 0);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 3);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 3);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 0);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 5);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 9);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 2);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 3);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 7);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 5);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 3);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 4);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 2);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 0);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 0);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "G06P206TimeLimit") == 1) {
                    context.State = new StateCheckP206(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP206 : TriggerState {
            internal StateCheckP206(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 0);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 0);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 3);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 3);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 0);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 5);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 9);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 2);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 3);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 7);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 5);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 3);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 4);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 2);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 0);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 0);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP206(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP206 : TriggerState {
            internal StateNumberOffP206(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {110}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {120}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {133}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {143}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {210}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {225}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {2309}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {242}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {313}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {3207}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {335}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {343}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {414}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {422}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {430}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {440}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP206(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP206 : TriggerState {
            internal StateResetP206(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G06P206End", value: 1);
                context.SetUserValue(key: "G06P206Set", value: 0);
                context.SetUserValue(key: "G06P206TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP207 : TriggerState {
            internal StateNumberOnP207(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7110, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7120, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7130, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7140, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7210, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7220, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7230, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7240, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7310, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7320, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7330, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7340, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7410, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7420, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7430, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7440, key: "ColorStart", value: 1);
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new[] {113}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {120}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {132}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {140}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {215}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {224}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {232}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {243}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {313}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {3208}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {3307}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {345}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {410}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {423}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {434}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {440}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 3);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 0);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 2);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 0);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 5);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 4);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 2);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 3);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 3);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 8);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 7);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 5);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 0);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 3);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 4);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 0);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "G06P207TimeLimit") == 1) {
                    context.State = new StateCheckP207(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP207 : TriggerState {
            internal StateCheckP207(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 3);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 0);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 2);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 0);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 5);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 4);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 2);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 3);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 3);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 8);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 7);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 5);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 0);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 3);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 4);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 0);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP207(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP207 : TriggerState {
            internal StateNumberOffP207(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {113}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {120}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {132}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {140}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {215}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {224}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {232}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {243}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {313}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {3208}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {3307}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {345}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {410}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {423}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {434}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {440}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP207(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP207 : TriggerState {
            internal StateResetP207(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G06P207End", value: 1);
                context.SetUserValue(key: "G06P207Set", value: 0);
                context.SetUserValue(key: "G06P207TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP208 : TriggerState {
            internal StateNumberOnP208(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7110, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7120, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7130, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7140, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7210, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7220, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7230, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7240, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7310, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7320, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7330, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7340, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7410, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7420, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7430, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7440, key: "ColorStart", value: 1);
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new[] {112}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {123}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {130}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {144}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {213}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {2209}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {234}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {240}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {314}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {322}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {3309}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {343}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {410}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {423}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {430}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {442}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 2);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 3);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 0);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 4);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 3);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 9);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 4);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 0);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 4);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 2);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 9);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 3);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 0);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 3);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 0);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 2);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "G06P208TimeLimit") == 1) {
                    context.State = new StateCheckP208(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP208 : TriggerState {
            internal StateCheckP208(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 2);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 3);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 0);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 4);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 3);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 9);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 4);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 0);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 4);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 2);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 9);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 3);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 0);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 3);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 0);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 2);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP208(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP208 : TriggerState {
            internal StateNumberOffP208(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {112}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {123}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {130}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {144}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {213}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {2209}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {234}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {240}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {314}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {322}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {3309}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {343}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {410}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {423}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {430}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {442}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP208(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP208 : TriggerState {
            internal StateResetP208(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G06P208End", value: 1);
                context.SetUserValue(key: "G06P208Set", value: 0);
                context.SetUserValue(key: "G06P208TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP209 : TriggerState {
            internal StateNumberOnP209(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7110, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7120, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7130, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7140, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7210, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7220, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7230, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7240, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7310, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7320, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7330, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7340, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7410, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7420, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7430, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7440, key: "ColorStart", value: 1);
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new[] {110}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {123}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {134}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {143}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {210}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {223}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {23010}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {23000}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {242}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {313}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {3207}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {332}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {344}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {413}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {422}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {433}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {440}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 0);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 3);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 4);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 3);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 0);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 3);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 6);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 2);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 3);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 7);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 2);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 4);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 3);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 2);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 3);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 0);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "G06P209TimeLimit") == 1) {
                    context.State = new StateCheckP209(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP209 : TriggerState {
            internal StateCheckP209(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 0);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 3);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 4);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 3);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 0);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 3);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 6);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 2);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 3);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 7);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 2);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 4);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 3);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 2);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 3);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 0);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP209(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP209 : TriggerState {
            internal StateNumberOffP209(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {110}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {123}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {134}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {143}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {210}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {223}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {23010}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {23000}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {242}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {313}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {3207}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {332}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {344}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {413}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {422}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {433}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {440}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP209(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP209 : TriggerState {
            internal StateResetP209(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G06P209End", value: 1);
                context.SetUserValue(key: "G06P209Set", value: 0);
                context.SetUserValue(key: "G06P209TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP210 : TriggerState {
            internal StateNumberOnP210(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7110, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7120, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7130, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7140, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7210, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7220, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7230, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7240, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7310, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7320, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7330, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7340, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7410, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7420, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7430, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7440, key: "ColorStart", value: 1);
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new[] {110}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {123}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {132}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {143}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {213}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {22010}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {22000}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {233}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {242}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {312}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {323}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {33010}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {33000}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {343}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {412}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {423}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {432}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {440}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 0);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 3);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 2);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 3);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 3);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 6);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 3);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 2);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 2);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 3);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 6);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 3);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 2);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 3);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 2);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 0);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "G06P210TimeLimit") == 1) {
                    context.State = new StateCheckP210(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP210 : TriggerState {
            internal StateCheckP210(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 0);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 3);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 2);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 3);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 3);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 6);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 3);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 2);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 2);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 3);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 6);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 3);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 2);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 3);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 2);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 0);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP210(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP210 : TriggerState {
            internal StateNumberOffP210(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {110}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {123}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {132}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {143}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {213}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {22010}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {22000}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {233}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {242}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {312}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {323}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {33010}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {33000}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {343}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {412}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {423}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {432}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {440}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP210(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP210 : TriggerState {
            internal StateResetP210(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G06P210End", value: 1);
                context.SetUserValue(key: "G06P210Set", value: 0);
                context.SetUserValue(key: "G06P210TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP211 : TriggerState {
            internal StateNumberOnP211(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7110, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7120, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7130, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7140, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7210, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7220, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7230, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7240, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7310, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7320, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7330, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7340, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7410, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7420, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7430, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7440, key: "ColorStart", value: 1);
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new[] {113}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {121}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {134}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {140}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {212}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {223}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {2307}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {245}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {315}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {3207}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {332}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {343}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {410}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {423}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {431}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {440}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 3);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 1);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 4);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 0);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 2);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 3);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 7);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 5);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 5);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 7);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 2);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 3);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 0);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 3);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 1);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 0);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "G06P211TimeLimit") == 1) {
                    context.State = new StateCheckP211(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP211 : TriggerState {
            internal StateCheckP211(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 3);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 1);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 4);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 0);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 2);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 3);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 7);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 5);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 5);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 7);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 2);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 3);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 0);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 3);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 1);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 0);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP211(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP211 : TriggerState {
            internal StateNumberOffP211(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {113}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {121}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {134}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {140}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {212}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {223}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {2307}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {245}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {315}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {3207}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {332}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {343}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {410}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {423}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {431}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {440}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP211(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP211 : TriggerState {
            internal StateResetP211(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G06P211End", value: 1);
                context.SetUserValue(key: "G06P211Set", value: 0);
                context.SetUserValue(key: "G06P211TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP212 : TriggerState {
            internal StateNumberOnP212(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7110, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7120, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7130, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7140, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7210, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7220, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7230, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7240, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7310, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7320, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7330, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7340, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7410, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7420, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7430, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7440, key: "ColorStart", value: 1);
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new[] {110}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {122}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {134}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {143}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {210}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {223}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {2308}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {244}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {312}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {324}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {333}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {340}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {410}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {423}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {432}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {442}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 0);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 2);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 4);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 3);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 0);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 3);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 8);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 4);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 2);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 4);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 3);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 0);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 0);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 3);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 2);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 2);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "G06P212TimeLimit") == 1) {
                    context.State = new StateCheckP212(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP212 : TriggerState {
            internal StateCheckP212(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 0);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 2);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 4);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 3);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 0);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 3);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 8);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 4);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 2);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 4);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 3);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 0);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 0);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 3);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 2);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 2);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP212(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP212 : TriggerState {
            internal StateNumberOffP212(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {110}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {122}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {134}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {143}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {210}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {223}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {2308}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {244}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {312}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {324}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {333}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {340}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {410}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {423}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {432}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {442}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP212(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP212 : TriggerState {
            internal StateResetP212(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G06P212End", value: 1);
                context.SetUserValue(key: "G06P212Set", value: 0);
                context.SetUserValue(key: "G06P212TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP213 : TriggerState {
            internal StateNumberOnP213(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7110, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7120, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7130, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7140, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7210, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7220, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7230, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7240, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7310, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7320, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7330, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7340, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7410, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7420, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7430, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7440, key: "ColorStart", value: 1);
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new[] {113}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {122}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {133}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {142}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {212}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {2208}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {233}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {240}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {313}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {322}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {330}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {343}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {412}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {423}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {433}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {442}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 3);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 2);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 3);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 2);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 2);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 8);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 3);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 0);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 3);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 2);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 0);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 3);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 2);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 3);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 3);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 2);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "G06P213TimeLimit") == 1) {
                    context.State = new StateCheckP213(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP213 : TriggerState {
            internal StateCheckP213(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 3);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 2);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 3);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 2);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 2);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 8);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 3);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 0);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 3);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 2);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 0);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 3);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 2);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 3);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 3);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 2);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP213(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP213 : TriggerState {
            internal StateNumberOffP213(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {113}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {122}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {133}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {142}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {212}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {2208}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {233}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {240}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {313}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {322}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {330}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {343}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {412}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {423}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {433}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {442}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP213(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP213 : TriggerState {
            internal StateResetP213(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G06P213End", value: 1);
                context.SetUserValue(key: "G06P213Set", value: 0);
                context.SetUserValue(key: "G06P213TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP214 : TriggerState {
            internal StateNumberOnP214(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7110, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7120, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7130, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7140, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7210, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7220, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7230, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7240, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7310, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7320, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7330, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7340, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7410, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7420, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7430, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7440, key: "ColorStart", value: 1);
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new[] {112}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {123}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {130}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {144}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {212}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {221}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {233}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {241}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {313}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {322}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {3309}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {343}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {410}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {422}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {435}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {441}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 2);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 3);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 0);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 4);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 2);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 1);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 3);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 1);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 3);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 2);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 9);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 3);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 0);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 2);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 5);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 1);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "G06P214TimeLimit") == 1) {
                    context.State = new StateCheckP214(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP214 : TriggerState {
            internal StateCheckP214(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 2);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 3);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 0);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 4);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 2);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 1);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 3);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 1);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 3);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 2);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 9);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 3);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 0);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 2);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 5);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 1);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP214(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP214 : TriggerState {
            internal StateNumberOffP214(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {112}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {123}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {130}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {144}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {212}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {221}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {233}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {241}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {313}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {322}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {3309}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {343}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {410}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {422}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {435}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {441}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP214(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP214 : TriggerState {
            internal StateResetP214(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G06P214End", value: 1);
                context.SetUserValue(key: "G06P214Set", value: 0);
                context.SetUserValue(key: "G06P214TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP215 : TriggerState {
            internal StateNumberOnP215(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7110, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7120, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7130, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7140, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7210, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7220, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7230, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7240, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7310, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7320, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7330, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7340, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7410, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7420, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7430, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7440, key: "ColorStart", value: 1);
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new[] {112}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {123}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {131}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {142}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {210}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {222}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {233}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {245}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {310}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {3209}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {332}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {341}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {415}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {423}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {431}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {443}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 2);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 3);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 1);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 2);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 0);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 2);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 3);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 5);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 0);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 9);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 2);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 1);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 5);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 3);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 1);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 3);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "G06P215TimeLimit") == 1) {
                    context.State = new StateCheckP215(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP215 : TriggerState {
            internal StateCheckP215(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 2);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 3);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 1);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 2);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 0);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 2);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 3);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 5);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 0);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 9);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 2);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 1);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 5);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 3);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 1);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 3);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP215(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP215 : TriggerState {
            internal StateNumberOffP215(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {112}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {123}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {131}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {142}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {210}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {222}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {233}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {245}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {310}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {3209}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {332}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {341}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {415}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {423}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {431}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {443}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP215(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP215 : TriggerState {
            internal StateResetP215(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G06P215End", value: 1);
                context.SetUserValue(key: "G06P215Set", value: 0);
                context.SetUserValue(key: "G06P215TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP216 : TriggerState {
            internal StateNumberOnP216(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7110, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7120, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7130, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7140, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7210, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7220, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7230, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7240, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7310, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7320, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7330, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7340, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7410, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7420, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7430, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7440, key: "ColorStart", value: 1);
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new[] {113}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {121}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {135}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {140}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {213}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {222}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {2309}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {243}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {315}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {322}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {331}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {340}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {411}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {425}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {433}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {442}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 3);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 1);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 5);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 0);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 3);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 2);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 9);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 3);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 5);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 2);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 1);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 0);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 1);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 5);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 3);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 2);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "G06P216TimeLimit") == 1) {
                    context.State = new StateCheckP216(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP216 : TriggerState {
            internal StateCheckP216(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 3);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 1);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 5);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 0);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 3);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 2);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 9);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 3);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 5);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 2);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 1);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 0);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 1);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 5);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 3);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 2);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP216(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP216 : TriggerState {
            internal StateNumberOffP216(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {113}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {121}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {135}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {140}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {213}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {222}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {2309}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {243}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {315}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {322}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {331}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {340}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {411}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {425}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {433}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {442}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP216(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP216 : TriggerState {
            internal StateResetP216(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G06P216End", value: 1);
                context.SetUserValue(key: "G06P216Set", value: 0);
                context.SetUserValue(key: "G06P216TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP217 : TriggerState {
            internal StateNumberOnP217(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7110, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7120, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7130, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7140, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7210, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7220, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7230, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7240, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7310, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7320, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7330, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7340, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7410, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7420, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7430, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7440, key: "ColorStart", value: 1);
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new[] {111}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {122}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {133}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {141}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {212}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {22010}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {22000}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {230}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {244}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {313}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {325}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {333}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {345}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {411}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {420}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {432}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {443}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 1);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 2);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 3);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 1);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 2);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 6);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 0);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 4);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 3);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 5);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 3);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 5);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 1);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 0);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 2);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 3);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "G06P217TimeLimit") == 1) {
                    context.State = new StateCheckP217(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP217 : TriggerState {
            internal StateCheckP217(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 1);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 2);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 3);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 1);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 2);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 6);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 0);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 4);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 3);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 5);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 3);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 5);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 1);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 0);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 2);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 3);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP217(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP217 : TriggerState {
            internal StateNumberOffP217(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {111}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {122}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {133}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {141}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {212}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {22010}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {22000}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {230}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {244}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {313}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {325}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {333}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {345}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {411}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {420}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {432}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {443}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP217(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP217 : TriggerState {
            internal StateResetP217(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G06P217End", value: 1);
                context.SetUserValue(key: "G06P217Set", value: 0);
                context.SetUserValue(key: "G06P217TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP218 : TriggerState {
            internal StateNumberOnP218(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7110, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7120, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7130, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7140, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7210, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7220, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7230, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7240, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7310, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7320, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7330, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7340, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7410, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7420, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7430, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7440, key: "ColorStart", value: 1);
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new[] {114}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {123}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {132}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {141}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {211}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {222}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {23010}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {23000}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {243}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {312}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {323}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {331}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {344}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {414}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {421}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {433}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {442}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 4);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 3);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 2);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 1);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 1);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 2);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 6);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 3);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 2);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 3);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 1);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 4);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 4);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 1);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 3);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 2);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "G06P218TimeLimit") == 1) {
                    context.State = new StateCheckP218(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP218 : TriggerState {
            internal StateCheckP218(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 4);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 3);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 2);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 1);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 1);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 2);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 6);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 3);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 2);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 3);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 1);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 4);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 4);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 1);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 3);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 2);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP218(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP218 : TriggerState {
            internal StateNumberOffP218(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {114}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {123}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {132}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {141}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {211}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {222}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {23010}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {23000}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {243}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {312}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {323}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {331}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {344}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {414}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {421}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {433}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {442}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP218(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP218 : TriggerState {
            internal StateResetP218(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G06P218End", value: 1);
                context.SetUserValue(key: "G06P218Set", value: 0);
                context.SetUserValue(key: "G06P218TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP219 : TriggerState {
            internal StateNumberOnP219(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7110, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7120, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7130, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7140, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7210, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7220, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7230, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7240, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7310, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7320, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7330, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7340, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7410, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7420, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7430, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7440, key: "ColorStart", value: 1);
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new[] {112}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {123}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {130}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {143}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {213}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {220}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {232}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {243}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {312}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {32010}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {32000}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {333}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {342}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {412}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {420}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {433}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {442}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 2);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 3);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 0);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 3);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 3);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 0);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 2);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 3);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 2);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 6);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 3);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 2);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 2);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 0);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 3);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 2);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "G06P219TimeLimit") == 1) {
                    context.State = new StateCheckP219(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP219 : TriggerState {
            internal StateCheckP219(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 2);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 3);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 0);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 3);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 3);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 0);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 2);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 3);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 2);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 6);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 3);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 2);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 2);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 0);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 3);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 2);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP219(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP219 : TriggerState {
            internal StateNumberOffP219(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {112}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {123}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {130}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {143}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {213}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {220}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {232}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {243}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {312}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {32010}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {32000}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {333}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {342}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {412}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {420}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {433}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {442}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP219(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP219 : TriggerState {
            internal StateResetP219(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G06P219End", value: 1);
                context.SetUserValue(key: "G06P219Set", value: 0);
                context.SetUserValue(key: "G06P219TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP220 : TriggerState {
            internal StateNumberOnP220(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7110, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7120, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7130, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7140, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7210, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7220, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7230, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7240, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7310, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7320, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7330, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7340, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7410, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7420, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7430, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7440, key: "ColorStart", value: 1);
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new[] {112}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {125}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {133}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {140}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {214}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {223}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {235}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {241}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {310}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {323}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {33010}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {33000}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {343}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {412}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {424}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {430}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {441}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 2);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 5);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 3);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 0);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 4);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 3);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 5);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 1);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 0);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 3);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 6);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 3);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 2);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 4);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 0);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 1);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "G06P220TimeLimit") == 1) {
                    context.State = new StateCheckP220(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP220 : TriggerState {
            internal StateCheckP220(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 2);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 5);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 3);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 0);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 4);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 3);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 5);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 1);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 0);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 3);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 6);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 3);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 2);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 4);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 0);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 1);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP220(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP220 : TriggerState {
            internal StateNumberOffP220(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {112}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {125}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {133}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {140}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {214}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {223}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {235}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {241}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {310}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {323}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {33010}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {33000}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {343}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {412}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {424}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {430}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {441}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP220(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP220 : TriggerState {
            internal StateResetP220(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G06P220End", value: 1);
                context.SetUserValue(key: "G06P220Set", value: 0);
                context.SetUserValue(key: "G06P220TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP301 : TriggerState {
            internal StateNumberOnP301(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7110, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7120, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7130, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7140, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7210, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7220, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7230, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7240, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7310, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7320, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7330, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7340, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7410, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7420, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7430, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7440, key: "ColorStart", value: 1);
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new[] {112}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {123}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {135}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {142}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {214}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {222}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {23010}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {23000}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {243}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {312}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {32010}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {32000}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {333}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {344}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {413}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {425}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {433}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {442}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 2);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 3);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 5);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 2);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 4);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 2);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 6);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 3);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 2);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 6);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 3);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 4);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 3);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 5);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 3);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 2);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "G06P301TimeLimit") == 1) {
                    context.State = new StateCheckP301(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP301 : TriggerState {
            internal StateCheckP301(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 2);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 3);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 5);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 2);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 4);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 2);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 6);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 3);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 2);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 6);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 3);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 4);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 3);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 5);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 3);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 2);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP301(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP301 : TriggerState {
            internal StateNumberOffP301(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {112}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {123}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {135}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {142}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {214}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {222}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {23010}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {23000}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {243}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {312}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {32010}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {32000}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {333}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {344}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {413}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {425}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {433}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {442}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP301(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP301 : TriggerState {
            internal StateResetP301(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G06P301End", value: 1);
                context.SetUserValue(key: "G06P301Set", value: 0);
                context.SetUserValue(key: "G06P301TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP302 : TriggerState {
            internal StateNumberOnP302(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7110, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7120, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7130, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7140, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7210, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7220, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7230, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7240, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7310, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7320, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7330, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7340, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7410, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7420, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7430, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7440, key: "ColorStart", value: 1);
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new[] {112}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {125}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {133}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {144}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {213}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {2208}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {232}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {244}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {312}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {324}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {33010}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {33000}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {343}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {414}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {423}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {435}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {442}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 2);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 5);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 3);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 4);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 3);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 8);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 2);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 4);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 2);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 4);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 6);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 3);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 4);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 3);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 5);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 2);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "G06P302TimeLimit") == 1) {
                    context.State = new StateCheckP302(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP302 : TriggerState {
            internal StateCheckP302(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 2);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 5);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 3);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 4);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 3);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 8);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 2);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 4);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 2);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 4);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 6);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 3);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 4);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 3);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 5);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 2);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP302(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP302 : TriggerState {
            internal StateNumberOffP302(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {112}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {125}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {133}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {144}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {213}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {2208}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {232}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {244}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {312}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {324}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {33010}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {33000}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {343}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {414}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {423}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {435}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {442}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP302(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP302 : TriggerState {
            internal StateResetP302(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G06P302End", value: 1);
                context.SetUserValue(key: "G06P302Set", value: 0);
                context.SetUserValue(key: "G06P302TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP303 : TriggerState {
            internal StateNumberOnP303(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7110, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7120, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7130, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7140, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7210, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7220, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7230, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7240, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7310, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7320, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7330, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7340, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7410, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7420, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7430, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7440, key: "ColorStart", value: 1);
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new[] {112}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {124}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {132}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {143}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {212}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {22010}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {22000}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {2309}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {243}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {315}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {323}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {332}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {345}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {413}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {422}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {434}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {443}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 2);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 4);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 2);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 3);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 2);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 6);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 9);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 3);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 5);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 3);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 2);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 5);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 3);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 2);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 4);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 3);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "G06P303TimeLimit") == 1) {
                    context.State = new StateCheckP303(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP303 : TriggerState {
            internal StateCheckP303(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 2);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 4);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 2);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 3);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 2);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 6);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 9);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 3);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 5);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 3);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 2);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 5);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 3);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 2);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 4);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 3);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP303(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP303 : TriggerState {
            internal StateNumberOffP303(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {112}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {124}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {132}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {143}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {212}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {22010}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {22000}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {2309}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {243}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {315}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {323}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {332}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {345}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {413}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {422}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {434}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {443}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP303(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP303 : TriggerState {
            internal StateResetP303(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G06P303End", value: 1);
                context.SetUserValue(key: "G06P303Set", value: 0);
                context.SetUserValue(key: "G06P303TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP304 : TriggerState {
            internal StateNumberOnP304(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7110, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7120, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7130, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7140, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7210, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7220, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7230, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7240, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7310, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7320, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7330, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7340, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7410, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7420, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7430, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7440, key: "ColorStart", value: 1);
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new[] {113}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {122}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {133}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {145}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {213}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {225}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {2309}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {242}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {313}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {32010}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {32000}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {332}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {343}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {415}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {422}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {433}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {442}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 3);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 2);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 3);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 5);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 3);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 5);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 9);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 2);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 3);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 6);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 2);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 3);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 5);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 2);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 3);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 2);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "G06P304TimeLimit") == 1) {
                    context.State = new StateCheckP304(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP304 : TriggerState {
            internal StateCheckP304(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 3);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 2);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 3);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 5);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 3);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 5);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 9);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 2);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 3);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 6);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 2);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 3);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 5);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 2);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 3);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 2);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP304(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP304 : TriggerState {
            internal StateNumberOffP304(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {113}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {122}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {133}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {145}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {213}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {225}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {2309}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {242}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {313}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {32010}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {32000}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {332}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {343}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {415}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {422}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {433}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {442}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP304(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP304 : TriggerState {
            internal StateResetP304(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G06P304End", value: 1);
                context.SetUserValue(key: "G06P304Set", value: 0);
                context.SetUserValue(key: "G06P304TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP305 : TriggerState {
            internal StateNumberOnP305(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7110, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7120, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7130, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7140, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7210, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7220, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7230, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7240, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7310, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7320, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7330, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7340, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7410, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7420, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7430, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7440, key: "ColorStart", value: 1);
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new[] {114}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {123}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {132}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {145}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {214}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {223}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {232}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {244}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {313}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {3209}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {3309}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {342}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {415}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {422}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {433}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {444}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 4);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 3);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 2);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 5);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 4);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 3);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 2);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 4);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 3);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 9);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 9);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 2);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 5);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 2);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 3);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 4);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "G06P305TimeLimit") == 1) {
                    context.State = new StateCheckP305(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP305 : TriggerState {
            internal StateCheckP305(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 4);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 3);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 2);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 5);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 4);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 3);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 2);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 4);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 3);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 9);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 9);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 2);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 5);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 2);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 3);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 4);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP305(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP305 : TriggerState {
            internal StateNumberOffP305(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {114}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {123}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {132}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {145}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {214}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {223}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {232}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {244}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {313}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {3209}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {3309}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {342}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {415}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {422}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {433}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {444}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP305(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP305 : TriggerState {
            internal StateResetP305(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G06P305End", value: 1);
                context.SetUserValue(key: "G06P305Set", value: 0);
                context.SetUserValue(key: "G06P305TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP306 : TriggerState {
            internal StateNumberOnP306(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7110, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7120, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7130, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7140, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7210, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7220, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7230, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7240, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7310, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7320, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7330, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7340, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7410, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7420, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7430, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7440, key: "ColorStart", value: 1);
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new[] {114}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {122}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {135}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {142}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {213}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {22010}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {22000}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {23010}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {23000}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {245}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {312}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {324}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {333}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {343}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {414}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {423}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {432}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {443}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 4);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 2);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 5);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 2);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 3);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 6);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 6);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 5);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 2);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 4);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 3);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 3);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 4);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 3);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 2);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 3);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "G06P306TimeLimit") == 1) {
                    context.State = new StateCheckP306(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP306 : TriggerState {
            internal StateCheckP306(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 4);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 2);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 5);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 2);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 3);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 6);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 6);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 5);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 2);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 4);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 3);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 3);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 4);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 3);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 2);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 3);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP306(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP306 : TriggerState {
            internal StateNumberOffP306(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {114}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {122}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {135}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {142}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {213}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {22010}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {22000}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {23010}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {23000}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {245}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {312}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {324}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {333}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {343}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {414}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {423}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {432}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {443}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP306(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP306 : TriggerState {
            internal StateResetP306(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G06P306End", value: 1);
                context.SetUserValue(key: "G06P306Set", value: 0);
                context.SetUserValue(key: "G06P306TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP307 : TriggerState {
            internal StateNumberOnP307(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7110, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7120, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7130, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7140, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7210, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7220, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7230, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7240, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7310, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7320, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7330, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7340, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7410, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7420, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7430, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7440, key: "ColorStart", value: 1);
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new[] {113}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {122}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {133}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {144}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {214}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {222}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {23010}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {23000}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {242}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {314}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {3208}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {3307}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {344}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {413}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {424}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {433}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {442}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 3);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 2);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 3);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 4);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 4);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 2);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 6);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 2);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 4);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 8);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 7);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 4);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 3);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 4);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 3);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 2);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "G06P307TimeLimit") == 1) {
                    context.State = new StateCheckP307(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP307 : TriggerState {
            internal StateCheckP307(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 3);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 2);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 3);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 4);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 4);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 2);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 6);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 2);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 4);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 8);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 7);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 4);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 3);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 4);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 3);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 2);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP307(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP307 : TriggerState {
            internal StateNumberOffP307(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {113}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {122}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {133}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {144}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {214}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {222}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {23010}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {23000}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {242}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {314}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {3208}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {3307}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {344}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {413}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {424}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {433}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {442}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP307(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP307 : TriggerState {
            internal StateResetP307(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G06P307End", value: 1);
                context.SetUserValue(key: "G06P307Set", value: 0);
                context.SetUserValue(key: "G06P307TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP308 : TriggerState {
            internal StateNumberOnP308(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7110, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7120, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7130, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7140, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7210, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7220, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7230, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7240, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7310, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7320, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7330, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7340, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7410, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7420, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7430, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7440, key: "ColorStart", value: 1);
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new[] {112}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {124}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {133}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {145}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {213}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {2207}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {2308}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {243}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {314}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {3209}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {332}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {342}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {413}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {425}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {432}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {443}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 2);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 4);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 3);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 5);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 3);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 7);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 8);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 3);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 4);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 9);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 2);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 2);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 3);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 5);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 2);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 3);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "G06P308TimeLimit") == 1) {
                    context.State = new StateCheckP308(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP308 : TriggerState {
            internal StateCheckP308(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 2);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 4);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 3);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 5);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 3);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 7);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 8);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 3);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 4);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 9);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 2);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 2);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 3);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 5);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 2);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 3);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP308(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP308 : TriggerState {
            internal StateNumberOffP308(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {112}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {124}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {133}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {145}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {213}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {2207}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {2308}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {243}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {314}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {3209}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {332}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {342}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {413}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {425}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {432}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {443}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP308(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP308 : TriggerState {
            internal StateResetP308(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G06P308End", value: 1);
                context.SetUserValue(key: "G06P308Set", value: 0);
                context.SetUserValue(key: "G06P308TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP309 : TriggerState {
            internal StateNumberOnP309(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7110, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7120, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7130, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7140, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7210, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7220, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7230, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7240, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7310, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7320, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7330, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7340, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7410, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7420, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7430, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7440, key: "ColorStart", value: 1);
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new[] {114}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {123}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {132}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {143}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {212}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {2208}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {2308}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {243}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {312}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {3208}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {334}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {343}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {414}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {423}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {434}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {444}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 4);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 3);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 2);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 3);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 2);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 8);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 8);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 3);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 2);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 8);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 4);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 3);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 4);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 3);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 4);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 4);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "G06P309TimeLimit") == 1) {
                    context.State = new StateCheckP309(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP309 : TriggerState {
            internal StateCheckP309(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 4);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 3);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 2);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 3);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 2);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 8);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 8);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 3);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 2);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 8);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 4);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 3);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 4);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 3);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 4);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 4);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP309(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP309 : TriggerState {
            internal StateNumberOffP309(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {114}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {123}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {132}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {143}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {212}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {2208}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {2308}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {243}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {312}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {3208}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {334}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {343}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {414}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {423}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {434}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {444}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP309(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP309 : TriggerState {
            internal StateResetP309(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G06P309End", value: 1);
                context.SetUserValue(key: "G06P309Set", value: 0);
                context.SetUserValue(key: "G06P309TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP310 : TriggerState {
            internal StateNumberOnP310(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7110, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7120, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7130, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7140, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7210, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7220, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7230, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7240, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7310, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7320, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7330, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7340, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7410, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7420, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7430, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7440, key: "ColorStart", value: 1);
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new[] {112}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {124}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {134}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {142}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {214}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {223}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {2307}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {244}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {313}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {3207}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {3307}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {342}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {414}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {423}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {432}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {443}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 2);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 4);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 4);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 2);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 4);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 3);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 7);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 4);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 3);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 7);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 7);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 2);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 4);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 3);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 2);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 3);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "G06P310TimeLimit") == 1) {
                    context.State = new StateCheckP310(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP310 : TriggerState {
            internal StateCheckP310(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 2);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 4);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 4);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 2);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 4);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 3);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 7);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 4);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 3);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 7);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 7);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 2);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 4);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 3);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 2);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 3);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP310(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP310 : TriggerState {
            internal StateNumberOffP310(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {112}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {124}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {134}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {142}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {214}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {223}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {2307}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {244}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {313}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {3207}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {3307}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {342}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {414}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {423}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {432}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {443}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP310(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP310 : TriggerState {
            internal StateResetP310(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G06P310End", value: 1);
                context.SetUserValue(key: "G06P310Set", value: 0);
                context.SetUserValue(key: "G06P310TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP311 : TriggerState {
            internal StateNumberOnP311(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7110, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7120, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7130, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7140, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7210, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7220, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7230, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7240, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7310, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7320, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7330, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7340, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7410, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7420, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7430, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7440, key: "ColorStart", value: 1);
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new[] {115}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {122}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {133}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {141}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {211}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {224}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {23010}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {23000}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {243}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {312}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {323}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {33010}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {33000}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {344}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {415}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {424}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {432}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {445}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 5);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 2);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 3);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 1);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 1);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 4);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 6);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 3);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 2);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 3);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 6);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 4);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 5);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 4);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 2);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 5);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "G06P311TimeLimit") == 1) {
                    context.State = new StateCheckP311(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP311 : TriggerState {
            internal StateCheckP311(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 5);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 2);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 3);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 1);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 1);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 4);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 6);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 3);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 2);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 3);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 6);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 4);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 5);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 4);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 2);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 5);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP311(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP311 : TriggerState {
            internal StateNumberOffP311(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {115}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {122}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {133}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {141}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {211}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {224}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {23010}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {23000}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {243}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {312}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {323}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {33010}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {33000}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {344}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {415}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {424}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {432}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {445}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP311(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP311 : TriggerState {
            internal StateResetP311(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G06P311End", value: 1);
                context.SetUserValue(key: "G06P311Set", value: 0);
                context.SetUserValue(key: "G06P311TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP312 : TriggerState {
            internal StateNumberOnP312(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7110, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7120, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7130, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7140, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7210, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7220, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7230, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7240, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7310, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7320, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7330, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7340, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7410, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7420, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7430, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7440, key: "ColorStart", value: 1);
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new[] {113}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {122}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {134}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {143}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {215}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {22010}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {22000}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {233}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {244}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {311}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {322}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {33010}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {33000}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {345}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {413}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {424}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {431}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {442}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 3);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 2);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 4);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 3);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 5);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 6);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 3);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 4);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 1);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 2);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 6);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 5);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 3);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 4);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 1);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 2);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "G06P312TimeLimit") == 1) {
                    context.State = new StateCheckP312(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP312 : TriggerState {
            internal StateCheckP312(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 3);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 2);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 4);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 3);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 5);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 6);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 3);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 4);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 1);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 2);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 6);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 5);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 3);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 4);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 1);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 2);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP312(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP312 : TriggerState {
            internal StateNumberOffP312(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {113}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {122}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {134}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {143}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {215}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {22010}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {22000}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {233}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {244}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {311}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {322}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {33010}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {33000}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {345}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {413}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {424}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {431}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {442}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP312(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP312 : TriggerState {
            internal StateResetP312(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G06P312End", value: 1);
                context.SetUserValue(key: "G06P312Set", value: 0);
                context.SetUserValue(key: "G06P312TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP313 : TriggerState {
            internal StateNumberOnP313(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7110, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7120, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7130, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7140, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7210, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7220, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7230, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7240, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7310, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7320, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7330, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7340, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7410, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7420, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7430, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7440, key: "ColorStart", value: 1);
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new[] {112}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {123}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {132}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {143}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {214}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {2208}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {234}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {243}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {312}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {3208}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {333}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {344}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {412}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {422}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {434}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {443}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 2);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 3);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 2);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 3);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 4);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 8);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 4);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 3);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 2);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 8);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 3);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 4);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 2);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 2);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 4);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 3);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "G06P313TimeLimit") == 1) {
                    context.State = new StateCheckP313(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP313 : TriggerState {
            internal StateCheckP313(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 2);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 3);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 2);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 3);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 4);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 8);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 4);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 3);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 2);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 8);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 3);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 4);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 2);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 2);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 4);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 3);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP313(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP313 : TriggerState {
            internal StateNumberOffP313(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {112}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {123}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {132}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {143}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {214}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {2208}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {234}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {243}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {312}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {3208}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {333}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {344}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {412}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {422}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {434}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {443}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP313(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP313 : TriggerState {
            internal StateResetP313(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G06P313End", value: 1);
                context.SetUserValue(key: "G06P313Set", value: 0);
                context.SetUserValue(key: "G06P313TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP314 : TriggerState {
            internal StateNumberOnP314(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7110, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7120, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7130, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7140, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7210, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7220, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7230, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7240, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7310, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7320, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7330, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7340, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7410, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7420, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7430, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7440, key: "ColorStart", value: 1);
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new[] {113}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {122}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {135}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {142}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {213}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {224}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {2309}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {243}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {314}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {322}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {3309}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {345}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {413}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {425}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {433}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {442}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 3);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 2);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 5);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 2);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 3);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 4);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 9);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 3);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 4);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 2);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 9);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 5);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 3);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 5);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 3);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 2);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "G06P314TimeLimit") == 1) {
                    context.State = new StateCheckP314(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP314 : TriggerState {
            internal StateCheckP314(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 3);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 2);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 5);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 2);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 3);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 4);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 9);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 3);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 4);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 2);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 9);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 5);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 3);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 5);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 3);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 2);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP314(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP314 : TriggerState {
            internal StateNumberOffP314(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {113}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {122}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {135}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {142}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {213}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {224}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {2309}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {243}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {314}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {322}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {3309}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {345}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {413}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {425}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {433}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {442}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP314(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP314 : TriggerState {
            internal StateResetP314(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G06P314End", value: 1);
                context.SetUserValue(key: "G06P314Set", value: 0);
                context.SetUserValue(key: "G06P314TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP315 : TriggerState {
            internal StateNumberOnP315(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7110, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7120, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7130, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7140, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7210, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7220, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7230, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7240, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7310, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7320, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7330, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7340, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7410, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7420, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7430, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7440, key: "ColorStart", value: 1);
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new[] {114}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {123}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {132}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {144}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {213}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {2207}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {235}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {242}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {313}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {325}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {3307}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {342}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {412}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {423}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {434}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {443}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 4);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 3);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 2);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 4);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 3);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 7);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 5);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 2);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 3);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 5);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 7);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 2);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 2);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 3);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 4);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 3);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "G06P315TimeLimit") == 1) {
                    context.State = new StateCheckP315(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP315 : TriggerState {
            internal StateCheckP315(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 4);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 3);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 2);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 4);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 3);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 7);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 5);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 2);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 3);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 5);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 7);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 2);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 2);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 3);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 4);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 3);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP315(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP315 : TriggerState {
            internal StateNumberOffP315(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {114}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {123}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {132}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {144}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {213}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {2207}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {235}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {242}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {313}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {325}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {3307}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {342}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {412}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {423}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {434}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {443}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP315(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP315 : TriggerState {
            internal StateResetP315(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G06P315End", value: 1);
                context.SetUserValue(key: "G06P315Set", value: 0);
                context.SetUserValue(key: "G06P315TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP316 : TriggerState {
            internal StateNumberOnP316(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7110, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7120, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7130, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7140, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7210, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7220, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7230, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7240, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7310, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7320, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7330, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7340, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7410, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7420, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7430, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7440, key: "ColorStart", value: 1);
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new[] {113}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {125}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {131}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {144}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {212}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {223}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {2307}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {242}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {313}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {3208}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {334}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {343}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {414}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {421}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {435}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {443}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 3);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 5);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 1);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 4);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 2);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 3);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 7);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 2);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 3);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 8);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 4);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 3);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 4);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 1);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 5);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 3);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "G06P316TimeLimit") == 1) {
                    context.State = new StateCheckP316(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP316 : TriggerState {
            internal StateCheckP316(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 3);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 5);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 1);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 4);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 2);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 3);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 7);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 2);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 3);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 8);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 4);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 3);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 4);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 1);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 5);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 3);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP316(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP316 : TriggerState {
            internal StateNumberOffP316(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {113}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {125}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {131}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {144}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {212}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {223}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {2307}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {242}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {313}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {3208}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {334}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {343}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {414}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {421}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {435}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {443}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP316(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP316 : TriggerState {
            internal StateResetP316(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G06P316End", value: 1);
                context.SetUserValue(key: "G06P316Set", value: 0);
                context.SetUserValue(key: "G06P316TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP317 : TriggerState {
            internal StateNumberOnP317(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7110, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7120, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7130, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7140, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7210, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7220, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7230, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7240, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7310, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7320, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7330, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7340, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7410, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7420, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7430, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7440, key: "ColorStart", value: 1);
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new[] {111}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {125}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {133}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {145}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {212}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {222}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {2309}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {243}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {311}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {322}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {3308}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {343}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {415}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {422}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {435}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {441}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 1);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 5);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 3);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 5);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 2);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 2);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 9);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 3);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 1);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 2);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 8);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 3);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 5);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 2);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 5);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 1);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "G06P317TimeLimit") == 1) {
                    context.State = new StateCheckP317(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP317 : TriggerState {
            internal StateCheckP317(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 1);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 5);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 3);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 5);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 2);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 2);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 9);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 3);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 1);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 2);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 8);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 3);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 5);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 2);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 5);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 1);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP317(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP317 : TriggerState {
            internal StateNumberOffP317(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {111}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {125}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {133}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {145}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {212}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {222}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {2309}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {243}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {311}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {322}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {3308}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {343}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {415}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {422}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {435}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {441}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP317(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP317 : TriggerState {
            internal StateResetP317(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G06P317End", value: 1);
                context.SetUserValue(key: "G06P317Set", value: 0);
                context.SetUserValue(key: "G06P317TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP318 : TriggerState {
            internal StateNumberOnP318(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7110, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7120, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7130, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7140, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7210, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7220, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7230, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7240, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7310, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7320, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7330, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7340, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7410, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7420, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7430, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7440, key: "ColorStart", value: 1);
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new[] {112}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {124}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {135}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {140}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {213}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {2208}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {234}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {242}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {314}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {3207}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {333}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {344}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {410}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {422}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {433}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {445}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 2);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 4);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 5);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 0);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 3);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 8);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 4);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 2);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 4);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 7);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 3);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 4);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 0);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 2);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 3);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 5);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "G06P318TimeLimit") == 1) {
                    context.State = new StateCheckP318(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP318 : TriggerState {
            internal StateCheckP318(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 2);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 4);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 5);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 0);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 3);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 8);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 4);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 2);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 4);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 7);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 3);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 4);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 0);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 2);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 3);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 5);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP318(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP318 : TriggerState {
            internal StateNumberOffP318(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {112}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {124}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {135}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {140}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {213}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {2208}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {234}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {242}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {314}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {3207}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {333}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {344}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {410}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {422}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {433}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {445}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP318(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP318 : TriggerState {
            internal StateResetP318(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G06P318End", value: 1);
                context.SetUserValue(key: "G06P318Set", value: 0);
                context.SetUserValue(key: "G06P318TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP319 : TriggerState {
            internal StateNumberOnP319(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7110, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7120, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7130, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7140, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7210, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7220, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7230, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7240, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7310, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7320, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7330, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7340, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7410, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7420, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7430, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7440, key: "ColorStart", value: 1);
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new[] {114}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {123}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {130}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {143}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {215}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {222}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {2308}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {244}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {313}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {3209}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {332}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {345}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {414}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {425}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {432}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {440}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 4);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 3);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 0);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 3);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 5);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 2);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 8);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 4);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 3);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 9);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 2);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 5);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 4);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 5);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 2);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 0);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "G06P319TimeLimit") == 1) {
                    context.State = new StateCheckP319(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP319 : TriggerState {
            internal StateCheckP319(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 4);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 3);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 0);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 3);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 5);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 2);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 8);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 4);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 3);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 9);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 2);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 5);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 4);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 5);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 2);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 0);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP319(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP319 : TriggerState {
            internal StateNumberOffP319(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {114}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {123}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {130}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {143}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {215}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {222}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {2308}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {244}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {313}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {3209}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {332}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {345}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {414}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {425}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {432}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {440}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP319(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP319 : TriggerState {
            internal StateResetP319(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G06P319End", value: 1);
                context.SetUserValue(key: "G06P319Set", value: 0);
                context.SetUserValue(key: "G06P319TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP320 : TriggerState {
            internal StateNumberOnP320(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7110, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7120, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7130, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7140, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7210, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7220, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7230, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7240, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7310, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7320, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7330, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7340, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7410, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7420, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7430, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7440, key: "ColorStart", value: 1);
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new[] {112}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {123}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {131}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {145}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {211}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {2209}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {233}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {245}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {315}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {321}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {3309}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {343}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {412}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {425}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {433}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {442}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 2);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 3);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 1);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 5);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 1);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 9);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 3);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 5);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 5);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 1);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 9);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 3);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 2);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 5);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 3);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 2);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "G06P320TimeLimit") == 1) {
                    context.State = new StateCheckP320(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP320 : TriggerState {
            internal StateCheckP320(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 2);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 3);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 1);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 5);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 1);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 9);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 3);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 5);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 5);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 1);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 9);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 3);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 2);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 5);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 3);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 2);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP320(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP320 : TriggerState {
            internal StateNumberOffP320(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {112}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {123}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {131}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {145}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {211}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {2209}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {233}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {245}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {315}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {321}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {3309}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {343}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {412}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {425}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {433}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {442}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP320(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP320 : TriggerState {
            internal StateResetP320(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G06P320End", value: 1);
                context.SetUserValue(key: "G06P320Set", value: 0);
                context.SetUserValue(key: "G06P320TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP401 : TriggerState {
            internal StateNumberOnP401(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7110, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7120, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7130, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7140, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7210, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7220, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7230, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7240, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7310, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7320, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7330, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7340, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7410, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7420, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7430, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7440, key: "ColorStart", value: 1);
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new[] {115}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {122}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {135}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {145}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {213}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {2209}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {233}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {245}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {315}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {3208}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {3307}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {342}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {415}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {423}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {432}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {445}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 5);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 2);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 5);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 5);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 3);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 9);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 3);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 5);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 5);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 8);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 7);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 2);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 5);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 3);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 2);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 5);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "G06P401TimeLimit") == 1) {
                    context.State = new StateCheckP401(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP401 : TriggerState {
            internal StateCheckP401(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 5);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 2);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 5);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 5);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 3);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 9);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 3);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 5);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 5);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 8);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 7);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 2);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 5);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 3);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 2);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 5);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP401(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP401 : TriggerState {
            internal StateNumberOffP401(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {115}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {122}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {135}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {145}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {213}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {2209}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {233}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {245}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {315}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {3208}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {3307}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {342}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {415}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {423}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {432}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {445}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP401(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP401 : TriggerState {
            internal StateResetP401(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G06P401End", value: 1);
                context.SetUserValue(key: "G06P401Set", value: 0);
                context.SetUserValue(key: "G06P401TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP402 : TriggerState {
            internal StateNumberOnP402(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7110, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7120, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7130, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7140, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7210, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7220, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7230, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7240, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7310, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7320, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7330, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7340, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7410, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7420, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7430, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7440, key: "ColorStart", value: 1);
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new[] {115}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {123}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {134}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {145}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {212}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {2209}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {23010}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {23000}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {245}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {313}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {3208}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {333}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {345}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {415}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {422}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {434}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {445}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 5);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 3);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 4);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 5);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 2);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 9);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 6);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 5);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 3);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 8);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 3);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 5);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 5);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 2);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 4);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 5);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "G06P402TimeLimit") == 1) {
                    context.State = new StateCheckP402(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP402 : TriggerState {
            internal StateCheckP402(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 5);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 3);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 4);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 5);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 2);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 9);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 6);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 5);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 3);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 8);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 3);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 5);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 5);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 2);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 4);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 5);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP402(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP402 : TriggerState {
            internal StateNumberOffP402(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {115}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {123}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {134}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {145}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {212}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {2209}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {23010}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {23000}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {245}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {313}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {3208}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {333}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {345}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {415}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {422}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {434}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {445}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP402(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP402 : TriggerState {
            internal StateResetP402(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G06P402End", value: 1);
                context.SetUserValue(key: "G06P402Set", value: 0);
                context.SetUserValue(key: "G06P402TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP403 : TriggerState {
            internal StateNumberOnP403(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7110, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7120, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7130, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7140, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7210, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7220, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7230, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7240, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7310, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7320, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7330, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7340, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7410, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7420, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7430, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7440, key: "ColorStart", value: 1);
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new[] {115}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {123}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {133}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {145}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {212}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {2207}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {2309}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {243}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {315}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {322}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {33010}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {33000}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {344}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {415}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {425}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {433}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {445}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 5);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 3);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 3);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 5);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 2);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 7);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 9);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 3);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 5);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 2);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 6);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 4);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 5);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 5);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 3);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 5);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "G06P403TimeLimit") == 1) {
                    context.State = new StateCheckP403(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP403 : TriggerState {
            internal StateCheckP403(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 5);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 3);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 3);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 5);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 2);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 7);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 9);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 3);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 5);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 2);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 6);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 4);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 5);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 5);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 3);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 5);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP403(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP403 : TriggerState {
            internal StateNumberOffP403(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {115}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {123}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {133}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {145}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {212}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {2207}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {2309}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {243}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {315}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {322}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {33010}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {33000}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {344}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {415}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {425}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {433}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {445}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP403(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP403 : TriggerState {
            internal StateResetP403(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G06P403End", value: 1);
                context.SetUserValue(key: "G06P403Set", value: 0);
                context.SetUserValue(key: "G06P403TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP404 : TriggerState {
            internal StateNumberOnP404(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7110, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7120, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7130, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7140, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7210, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7220, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7230, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7240, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7310, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7320, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7330, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7340, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7410, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7420, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7430, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7440, key: "ColorStart", value: 1);
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new[] {115}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {124}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {132}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {145}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {213}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {225}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {23010}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {23000}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {243}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {315}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {32010}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {32000}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {33010}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {33000}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {345}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {413}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {425}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {432}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {443}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 5);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 4);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 2);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 5);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 3);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 5);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 6);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 3);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 5);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 6);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 6);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 5);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 3);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 5);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 2);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 3);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "G06P404TimeLimit") == 1) {
                    context.State = new StateCheckP404(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP404 : TriggerState {
            internal StateCheckP404(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 5);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 4);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 2);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 5);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 3);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 5);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 6);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 3);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 5);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 6);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 6);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 5);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 3);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 5);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 2);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 3);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP404(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP404 : TriggerState {
            internal StateNumberOffP404(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {115}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {124}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {132}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {145}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {213}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {225}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {23010}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {23000}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {243}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {315}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {32010}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {32000}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {33010}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {33000}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {345}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {413}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {425}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {432}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {443}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP404(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP404 : TriggerState {
            internal StateResetP404(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G06P404End", value: 1);
                context.SetUserValue(key: "G06P404Set", value: 0);
                context.SetUserValue(key: "G06P404TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP405 : TriggerState {
            internal StateNumberOnP405(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7110, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7120, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7130, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7140, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7210, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7220, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7230, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7240, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7310, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7320, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7330, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7340, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7410, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7420, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7430, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7440, key: "ColorStart", value: 1);
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new[] {113}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {125}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {135}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {143}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {215}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {2209}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {2309}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {242}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {312}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {3209}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {332}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {345}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {415}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {425}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {433}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {445}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 3);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 5);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 5);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 3);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 5);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 9);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 9);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 2);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 2);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 9);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 2);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 5);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 5);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 5);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 3);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 5);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "G06P405TimeLimit") == 1) {
                    context.State = new StateCheckP405(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP405 : TriggerState {
            internal StateCheckP405(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 3);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 5);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 5);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 3);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 5);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 9);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 9);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 2);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 2);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 9);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 2);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 5);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 5);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 5);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 3);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 5);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP405(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP405 : TriggerState {
            internal StateNumberOffP405(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {113}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {125}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {135}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {143}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {215}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {2209}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {2309}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {242}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {312}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {3209}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {332}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {345}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {415}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {425}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {433}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {445}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP405(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP405 : TriggerState {
            internal StateResetP405(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G06P405End", value: 1);
                context.SetUserValue(key: "G06P405Set", value: 0);
                context.SetUserValue(key: "G06P405TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP406 : TriggerState {
            internal StateNumberOnP406(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7110, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7120, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7130, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7140, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7210, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7220, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7230, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7240, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7310, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7320, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7330, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7340, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7410, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7420, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7430, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7440, key: "ColorStart", value: 1);
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new[] {115}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {125}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {133}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {145}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {214}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {223}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {2308}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {244}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {313}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {3208}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {3308}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {343}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {415}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {424}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {433}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {445}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 5);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 5);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 3);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 5);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 4);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 3);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 8);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 4);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 3);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 8);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 8);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 3);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 5);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 4);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 3);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 5);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "G06P406TimeLimit") == 1) {
                    context.State = new StateCheckP406(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP406 : TriggerState {
            internal StateCheckP406(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 5);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 5);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 3);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 5);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 4);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 3);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 8);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 4);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 3);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 8);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 8);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 3);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 5);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 4);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 3);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 5);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP406(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP406 : TriggerState {
            internal StateNumberOffP406(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {115}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {125}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {133}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {145}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {214}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {223}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {2308}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {244}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {313}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {3208}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {3308}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {343}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {415}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {424}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {433}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {445}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP406(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP406 : TriggerState {
            internal StateResetP406(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G06P406End", value: 1);
                context.SetUserValue(key: "G06P406Set", value: 0);
                context.SetUserValue(key: "G06P406TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP407 : TriggerState {
            internal StateNumberOnP407(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7110, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7120, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7130, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7140, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7210, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7220, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7230, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7240, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7310, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7320, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7330, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7340, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7410, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7420, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7430, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7440, key: "ColorStart", value: 1);
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new[] {114}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {123}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {135}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {143}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {215}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {2208}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {2308}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {245}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {315}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {325}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {3309}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {342}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {414}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {422}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {435}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {444}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 4);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 3);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 5);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 3);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 5);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 8);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 8);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 5);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 5);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 5);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 9);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 2);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 4);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 2);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 5);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 4);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "G06P407TimeLimit") == 1) {
                    context.State = new StateCheckP407(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP407 : TriggerState {
            internal StateCheckP407(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 4);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 3);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 5);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 3);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 5);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 8);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 8);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 5);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 5);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 5);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 9);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 2);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 4);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 2);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 5);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 4);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP407(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP407 : TriggerState {
            internal StateNumberOffP407(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {114}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {123}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {135}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {143}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {215}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {2208}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {2308}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {245}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {315}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {325}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {3309}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {342}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {414}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {422}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {435}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {444}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP407(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP407 : TriggerState {
            internal StateResetP407(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G06P407End", value: 1);
                context.SetUserValue(key: "G06P407Set", value: 0);
                context.SetUserValue(key: "G06P407TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP408 : TriggerState {
            internal StateNumberOnP408(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7110, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7120, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7130, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7140, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7210, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7220, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7230, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7240, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7310, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7320, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7330, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7340, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7410, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7420, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7430, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7440, key: "ColorStart", value: 1);
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new[] {113}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {125}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {134}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {145}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {212}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {22010}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {22000}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {235}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {244}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {314}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {32010}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {32000}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {3307}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {343}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {415}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {422}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {435}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {444}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 3);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 5);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 4);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 5);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 2);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 6);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 5);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 4);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 4);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 6);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 7);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 3);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 5);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 2);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 5);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 4);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "G06P408TimeLimit") == 1) {
                    context.State = new StateCheckP408(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP408 : TriggerState {
            internal StateCheckP408(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 3);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 5);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 4);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 5);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 2);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 6);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 5);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 4);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 4);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 6);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 7);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 3);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 5);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 2);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 5);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 4);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP408(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP408 : TriggerState {
            internal StateNumberOffP408(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {113}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {125}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {134}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {145}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {212}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {22010}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {22000}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {235}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {244}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {314}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {32010}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {32000}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {3307}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {343}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {415}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {422}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {435}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {444}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP408(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP408 : TriggerState {
            internal StateResetP408(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G06P408End", value: 1);
                context.SetUserValue(key: "G06P408Set", value: 0);
                context.SetUserValue(key: "G06P408TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP409 : TriggerState {
            internal StateNumberOnP409(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7110, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7120, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7130, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7140, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7210, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7220, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7230, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7240, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7310, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7320, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7330, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7340, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7410, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7420, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7430, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7440, key: "ColorStart", value: 1);
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new[] {114}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {124}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {135}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {143}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {212}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {2209}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {2308}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {245}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {312}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {324}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {3309}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {345}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {414}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {424}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {435}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {443}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 4);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 4);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 5);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 3);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 2);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 9);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 8);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 5);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 2);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 4);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 9);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 5);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 4);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 4);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 5);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 3);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "G06P409TimeLimit") == 1) {
                    context.State = new StateCheckP409(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP409 : TriggerState {
            internal StateCheckP409(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 4);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 4);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 5);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 3);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 2);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 9);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 8);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 5);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 2);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 4);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 9);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 5);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 4);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 4);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 5);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 3);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP409(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP409 : TriggerState {
            internal StateNumberOffP409(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {114}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {124}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {135}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {143}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {212}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {2209}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {2308}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {245}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {312}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {324}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {3309}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {345}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {414}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {424}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {435}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {443}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP409(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP409 : TriggerState {
            internal StateResetP409(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G06P409End", value: 1);
                context.SetUserValue(key: "G06P409Set", value: 0);
                context.SetUserValue(key: "G06P409TimeLimit", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP410 : TriggerState {
            internal StateNumberOnP410(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7110, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7120, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7130, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7140, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7210, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7220, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7230, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7240, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7310, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7320, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7330, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7340, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7410, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7420, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7430, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7440, key: "ColorStart", value: 1);
                context.PlaySystemSoundInBox(arg1: new[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new[] {112}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {125}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {135}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {143}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {215}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {22010}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {22000}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {234}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {244}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {314}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {3209}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {33010}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {33000}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {345}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {413}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {425}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {435}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {442}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 2);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 5);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 5);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 3);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 5);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 6);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 4);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 4);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 4);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 9);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 6);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 5);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 3);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 5);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 5);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 2);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "G06P410TimeLimit") == 1) {
                    context.State = new StateCheckP410(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckP410 : TriggerState {
            internal StateCheckP410(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 2);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 5);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 5);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 3);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 5);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 6);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 4);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 4);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 4);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 9);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 6);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 5);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 3);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 5);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 5);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 2);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP410(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP410 : TriggerState {
            internal StateNumberOffP410(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {112}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {125}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {135}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {143}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {215}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {22010}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {22000}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {234}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {244}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {314}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {3209}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {33010}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {33000}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {345}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {413}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {425}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {435}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {442}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP410(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetP410 : TriggerState {
            internal StateResetP410(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G06P410End", value: 1);
                context.SetUserValue(key: "G06P410Set", value: 0);
                context.SetUserValue(key: "G06P410TimeLimit", value: 0);
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