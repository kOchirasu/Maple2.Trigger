namespace Maple2.Trigger._02000254_bf {
    public static class _scene01 {
        public class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {101});
                context.CreateMonster(arg1: new[] {107});
                context.SetMesh(arg1: new[] {3001}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3002}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {601}, arg2: false);
                context.SetEffect(arg1: new[] {602}, arg2: false);
                context.SetEffect(arg1: new[] {603}, arg2: false);
                context.SetEffect(arg1: new[] {604}, arg2: false);
                context.SetEffect(arg1: new[] {605}, arg2: false);
                context.SetEffect(arg1: new[] {606}, arg2: false);
                context.SetEffect(arg1: new[] {607}, arg2: false);
                context.SetEffect(arg1: new[] {608}, arg2: false);
                context.SetEffect(arg1: new[] {401}, arg2: false);
                context.SetEffect(arg1: new[] {402}, arg2: false);
                context.SetEffect(arg1: new[] {403}, arg2: false);
                context.SetEffect(arg1: new[] {404}, arg2: false);
                context.SetEffect(arg1: new[] {405}, arg2: false);
                context.SetEffect(arg1: new[] {406}, arg2: false);
                context.SetEffect(arg1: new[] {407}, arg2: false);
                context.SetEffect(arg1: new[] {408}, arg2: false);
                context.SetEffect(arg1: new[] {409}, arg2: false);
                context.SetEffect(arg1: new[] {410}, arg2: false);
                context.SetEffect(arg1: new[] {411}, arg2: false);
                context.SetEffect(arg1: new[] {412}, arg2: false);
                context.SetEffect(arg1: new[] {413}, arg2: false);
                context.SetEffect(arg1: new[] {414}, arg2: false);
                context.SetEffect(arg1: new[] {415}, arg2: false);
                context.SetEffect(arg1: new[] {416}, arg2: false);
                context.SetEffect(arg1: new[] {417}, arg2: false);
                context.SetEffect(arg1: new[] {418}, arg2: false);
                context.SetEffect(arg1: new[] {419}, arg2: false);
                context.SetEffect(arg1: new[] {420}, arg2: false);
                context.SetEffect(arg1: new[] {421}, arg2: false);
                context.SetEffect(arg1: new[] {422}, arg2: false);
                context.SetEffect(arg1: new[] {423}, arg2: false);
                context.SetEffect(arg1: new[] {424}, arg2: false);
                context.SetEffect(arg1: new[] {425}, arg2: false);
                context.SetEffect(arg1: new[] {426}, arg2: false);
                context.SetEffect(arg1: new[] {427}, arg2: false);
                context.SetEffect(arg1: new[] {428}, arg2: false);
                context.SetEffect(arg1: new[] {429}, arg2: false);
                context.SetEffect(arg1: new[] {430}, arg2: false);
                context.SetEffect(arg1: new[] {431}, arg2: false);
                context.SetEffect(arg1: new[] {432}, arg2: false);
                context.SetEffect(arg1: new[] {433}, arg2: false);
                context.SetEffect(arg1: new[] {434}, arg2: false);
                context.SetEffect(arg1: new[] {435}, arg2: false);
                context.SetEffect(arg1: new[] {436}, arg2: false);
                context.SetEffect(arg1: new[] {437}, arg2: false);
                context.SetEffect(arg1: new[] {438}, arg2: false);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 901) == 1) {
                    context.State = new State연출시작딜레이(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출시작딜레이 : TriggerState {
            internal State연출시작딜레이(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 301, arg2: true);
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State연출시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출시작 : TriggerState {
            internal State연출시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 2);
                context.SetSceneSkip(arg1: "스킵벨라이동딜레이", arg2: "nextState");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State대화시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대화시작 : TriggerState {
            internal State대화시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {401}, arg2: false);
                context.SetTimer(arg1: "1", arg2: 6);
                context.AddCinematicTalk(npcId: 11000074, illustId: "Karl_closeEye", msg: "$02000254_BF__SCENE01__0$",
                    duration: 6000, align: "center");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State벨라대사1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State벨라대사1 : TriggerState {
            internal State벨라대사1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 4);
                context.SetConversation(arg1: 2, arg2: 11000057, arg3: "$02000254_BF__SCENE01__1$", arg4: 4);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State벨라대사2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State벨라대사2 : TriggerState {
            internal State벨라대사2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 7);
                context.SetConversation(arg1: 2, arg2: 11000057, arg3: "$02000254_BF__SCENE01__2$", arg4: 4);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State칼대사1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State칼대사1 : TriggerState {
            internal State칼대사1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 5);
                context.AddCinematicTalk(npcId: 11000074, illustId: "Karl_closeEye", msg: "$02000254_BF__SCENE01__3$",
                    duration: 5000, align: "center");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State칼대사2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State칼대사2 : TriggerState {
            internal State칼대사2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 5);
                context.AddCinematicTalk(npcId: 11000074, illustId: "Karl_closeEye", msg: "$02000254_BF__SCENE01__4$",
                    duration: 5000, align: "center");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State벨라대사3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State벨라대사3 : TriggerState {
            internal State벨라대사3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 6);
                context.SetConversation(arg1: 2, arg2: 11000057, arg3: "$02000254_BF__SCENE01__5$", arg4: 5);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State벨라대사4(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State벨라대사4 : TriggerState {
            internal State벨라대사4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 10);
                context.SetConversation(arg1: 2, arg2: 11000057, arg3: "$02000254_BF__SCENE01__6$", arg4: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State벨라이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State벨라이동딜레이 : TriggerState {
            internal State벨라이동딜레이(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State벨라이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State벨라이동 : TriggerState {
            internal State벨라이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3001}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_1");
            }

            public override void Execute() {
                if (true) {
                    context.State = new State카메라원위치(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카메라원위치 : TriggerState {
            internal State카메라원위치(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 2);
                context.CameraSelectPath(arg1: new[] {301}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State카메라원위치2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카메라원위치2 : TriggerState {
            internal State카메라원위치2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 902) == 1) {
                    context.State = new State쿠당탕(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State쿠당탕 : TriggerState {
            internal State쿠당탕(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {101});
                context.CreateMonster(arg1: new[] {102});
                context.SetEffect(arg1: new[] {402}, arg2: true);
                context.SetEffect(arg1: new[] {403}, arg2: true);
                context.SetEffect(arg1: new[] {404}, arg2: true);
                context.SetEffect(arg1: new[] {405}, arg2: true);
                context.SetEffect(arg1: new[] {406}, arg2: true);
                context.SetEffect(arg1: new[] {407}, arg2: true);
                context.SetEffect(arg1: new[] {408}, arg2: true);
                context.SetEffect(arg1: new[] {409}, arg2: true);
                context.SetEffect(arg1: new[] {410}, arg2: true);
                context.SetEffect(arg1: new[] {411}, arg2: true);
                context.SetEffect(arg1: new[] {412}, arg2: true);
                context.SetEffect(arg1: new[] {413}, arg2: true);
                context.SetEffect(arg1: new[] {414}, arg2: true);
                context.SetEffect(arg1: new[] {415}, arg2: true);
                context.SetEffect(arg1: new[] {416}, arg2: true);
                context.SetEffect(arg1: new[] {417}, arg2: true);
                context.SetEffect(arg1: new[] {418}, arg2: true);
                context.SetEffect(arg1: new[] {419}, arg2: true);
                context.SetEffect(arg1: new[] {420}, arg2: true);
                context.SetEffect(arg1: new[] {421}, arg2: true);
                context.SetEffect(arg1: new[] {422}, arg2: true);
                context.SetEffect(arg1: new[] {423}, arg2: true);
                context.SetEffect(arg1: new[] {424}, arg2: true);
                context.SetEffect(arg1: new[] {425}, arg2: true);
                context.SetEffect(arg1: new[] {426}, arg2: true);
                context.SetEffect(arg1: new[] {427}, arg2: true);
                context.SetEffect(arg1: new[] {428}, arg2: true);
                context.SetEffect(arg1: new[] {429}, arg2: true);
                context.SetEffect(arg1: new[] {430}, arg2: true);
                context.SetEffect(arg1: new[] {431}, arg2: true);
                context.SetEffect(arg1: new[] {432}, arg2: true);
                context.SetEffect(arg1: new[] {433}, arg2: true);
                context.SetEffect(arg1: new[] {434}, arg2: true);
                context.SetEffect(arg1: new[] {435}, arg2: true);
                context.SetEffect(arg1: new[] {436}, arg2: true);
                context.SetEffect(arg1: new[] {437}, arg2: true);
                context.SetEffect(arg1: new[] {438}, arg2: true);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State벨라대사5(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킵벨라이동딜레이 : TriggerState {
            internal State스킵벨라이동딜레이(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetTimer(arg1: "1", arg2: 1);
                context.CameraSelectPath(arg1: new[] {301}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킵벨라이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킵벨라이동 : TriggerState {
            internal State스킵벨라이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3001}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_1");
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킵카메라원위치(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킵카메라원위치 : TriggerState {
            internal State스킵카메라원위치(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserCount(boxId: 902) == 1) {
                    context.State = new State스킵쿠당탕(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킵쿠당탕 : TriggerState {
            internal State스킵쿠당탕(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {101});
                context.CreateMonster(arg1: new[] {102});
                context.SetEffect(arg1: new[] {402}, arg2: true);
                context.SetEffect(arg1: new[] {403}, arg2: true);
                context.SetEffect(arg1: new[] {404}, arg2: true);
                context.SetEffect(arg1: new[] {405}, arg2: true);
                context.SetEffect(arg1: new[] {406}, arg2: true);
                context.SetEffect(arg1: new[] {407}, arg2: true);
                context.SetEffect(arg1: new[] {408}, arg2: true);
                context.SetEffect(arg1: new[] {409}, arg2: true);
                context.SetEffect(arg1: new[] {410}, arg2: true);
                context.SetEffect(arg1: new[] {411}, arg2: true);
                context.SetEffect(arg1: new[] {412}, arg2: true);
                context.SetEffect(arg1: new[] {413}, arg2: true);
                context.SetEffect(arg1: new[] {414}, arg2: true);
                context.SetEffect(arg1: new[] {415}, arg2: true);
                context.SetEffect(arg1: new[] {416}, arg2: true);
                context.SetEffect(arg1: new[] {417}, arg2: true);
                context.SetEffect(arg1: new[] {418}, arg2: true);
                context.SetEffect(arg1: new[] {419}, arg2: true);
                context.SetEffect(arg1: new[] {420}, arg2: true);
                context.SetEffect(arg1: new[] {421}, arg2: true);
                context.SetEffect(arg1: new[] {422}, arg2: true);
                context.SetEffect(arg1: new[] {423}, arg2: true);
                context.SetEffect(arg1: new[] {424}, arg2: true);
                context.SetEffect(arg1: new[] {425}, arg2: true);
                context.SetEffect(arg1: new[] {426}, arg2: true);
                context.SetEffect(arg1: new[] {427}, arg2: true);
                context.SetEffect(arg1: new[] {428}, arg2: true);
                context.SetEffect(arg1: new[] {429}, arg2: true);
                context.SetEffect(arg1: new[] {430}, arg2: true);
                context.SetEffect(arg1: new[] {431}, arg2: true);
                context.SetEffect(arg1: new[] {432}, arg2: true);
                context.SetEffect(arg1: new[] {433}, arg2: true);
                context.SetEffect(arg1: new[] {434}, arg2: true);
                context.SetEffect(arg1: new[] {435}, arg2: true);
                context.SetEffect(arg1: new[] {436}, arg2: true);
                context.SetEffect(arg1: new[] {437}, arg2: true);
                context.SetEffect(arg1: new[] {438}, arg2: true);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State벨라대사5딜레이(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State벨라대사5딜레이 : TriggerState {
            internal State벨라대사5딜레이(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "2", arg2: 2);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    context.State = new State벨라대사5(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State벨라대사5 : TriggerState {
            internal State벨라대사5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 301, arg2: true);
                context.SetSceneSkip(arg1: "벨라이동2", arg2: "nextState");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetTimer(arg1: "1", arg2: 6);
                context.SetConversation(arg1: 2, arg2: 11000057, arg3: "$02000254_BF__SCENE01__7$", arg4: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State벨라대사6(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State벨라대사6 : TriggerState {
            internal State벨라대사6(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 4);
                context.SetConversation(arg1: 2, arg2: 11000057, arg3: "$02000254_BF__SCENE01__8$", arg4: 2);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State벨라이동2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State벨라이동2 : TriggerState {
            internal State벨라이동2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetTimer(arg1: "1", arg2: 4);
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_2");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State이펙트1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이펙트1 : TriggerState {
            internal State이펙트1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetEffect(arg1: new[] {401}, arg2: true);
                context.DestroyMonster(arg1: new[] {102});
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State벨라몬스터소환(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State벨라몬스터소환 : TriggerState {
            internal State벨라몬스터소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 3);
                context.CameraSelect(arg1: 303, arg2: true);
                context.CreateMonster(arg1: new[] {106});
                context.CreateMonster(arg1: new[] {103});
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State끝(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State끝 : TriggerState {
            internal State끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 2);
                context.CameraSelectPath(arg1: new[] {303}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State끝2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State끝2 : TriggerState {
            internal State끝2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 301, arg2: false);
                context.CameraSelect(arg1: 303, arg2: false);
                context.SetMesh(arg1: new[] {3002}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}