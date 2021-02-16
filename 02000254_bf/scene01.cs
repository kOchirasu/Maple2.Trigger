using Maple2.Trigger.Enum;

namespace Maple2.Trigger._02000254_bf {
    public static class _scene01 {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {101});
                context.CreateMonster(arg1: new[] {107});
                context.SetMesh(arg1: new[] {3001, 3002}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 401, 402, 403, 404, 405, 406, 407, 408, 409, 410, 411, 412, 413, 414, 415, 416, 417, 418, 419, 420, 421, 422, 423, 424, 425, 426, 427, 428, 429, 430, 431, 432, 433, 434, 435, 436, 437, 438}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 901) == 1) {
                    return new StateStartCinematicDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematicDelay : TriggerState {
            internal StateStartCinematicDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(arg1: 301, arg2: true);
                context.SetTimer(id: "1", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateStartCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematic : TriggerState {
            internal StateStartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "1", arg2: 2);
                context.SetSceneSkip(state: new State스킵벨라이동Delay(context), arg2: "nextState");
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State대화시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대화시작 : TriggerState {
            internal State대화시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {401}, arg2: false);
                context.SetTimer(id: "1", arg2: 6);
                context.AddCinematicTalk(npcId: 11000074, illustId: "Karl_closeEye", script: "$02000254_BF__SCENE01__0$", duration: 6000, align: Align.Center);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State벨라Script1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벨라Script1 : TriggerState {
            internal State벨라Script1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "1", arg2: 4);
                context.SetConversation(arg1: 2, arg2: 11000057, script: "$02000254_BF__SCENE01__1$", arg4: 4);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State벨라Script2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벨라Script2 : TriggerState {
            internal State벨라Script2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "1", arg2: 7);
                context.SetConversation(arg1: 2, arg2: 11000057, script: "$02000254_BF__SCENE01__2$", arg4: 4);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State칼Script1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State칼Script1 : TriggerState {
            internal State칼Script1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "1", arg2: 5);
                context.AddCinematicTalk(npcId: 11000074, illustId: "Karl_closeEye", script: "$02000254_BF__SCENE01__3$", duration: 5000, align: Align.Center);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State칼Script2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State칼Script2 : TriggerState {
            internal State칼Script2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "1", arg2: 5);
                context.AddCinematicTalk(npcId: 11000074, illustId: "Karl_closeEye", script: "$02000254_BF__SCENE01__4$", duration: 5000, align: Align.Center);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State벨라Script3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벨라Script3 : TriggerState {
            internal State벨라Script3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "1", arg2: 6);
                context.SetConversation(arg1: 2, arg2: 11000057, script: "$02000254_BF__SCENE01__5$", arg4: 5);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State벨라Script4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벨라Script4 : TriggerState {
            internal State벨라Script4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "1", arg2: 10);
                context.SetConversation(arg1: 2, arg2: 11000057, script: "$02000254_BF__SCENE01__6$", arg4: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State벨라이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벨라이동Delay : TriggerState {
            internal State벨라이동Delay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "1", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State벨라이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벨라이동 : TriggerState {
            internal State벨라이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3001}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_1");
            }

            public override TriggerState Execute() {
                return new StateCamera원위치(context);
            }

            public override void OnExit() { }
        }

        private class StateCamera원위치 : TriggerState {
            internal StateCamera원위치(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "1", arg2: 2);
                context.CameraSelectPath(pathIds: new[] {301}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateCamera원위치2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera원위치2 : TriggerState {
            internal StateCamera원위치2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 902) == 1) {
                    return new State쿠당탕(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State쿠당탕 : TriggerState {
            internal State쿠당탕(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {101});
                context.CreateMonster(arg1: new[] {102});
                context.SetEffect(arg1: new[] {402, 403, 404, 405, 406, 407, 408, 409, 410, 411, 412, 413, 414, 415, 416, 417, 418, 419, 420, 421, 422, 423, 424, 425, 426, 427, 428, 429, 430, 431, 432, 433, 434, 435, 436, 437, 438}, arg2: true);
            }

            public override TriggerState Execute() {
                return new State벨라Script5(context);
            }

            public override void OnExit() { }
        }

        private class State스킵벨라이동Delay : TriggerState {
            internal State스킵벨라이동Delay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetTimer(id: "1", arg2: 1);
                context.CameraSelectPath(pathIds: new[] {301}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State스킵벨라이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스킵벨라이동 : TriggerState {
            internal State스킵벨라이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3001}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_1");
            }

            public override TriggerState Execute() {
                return new State스킵Camera원위치(context);
            }

            public override void OnExit() { }
        }

        private class State스킵Camera원위치 : TriggerState {
            internal State스킵Camera원위치(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 902) == 1) {
                    return new State스킵쿠당탕(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스킵쿠당탕 : TriggerState {
            internal State스킵쿠당탕(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {101});
                context.CreateMonster(arg1: new[] {102});
                context.SetEffect(arg1: new[] {402, 403, 404, 405, 406, 407, 408, 409, 410, 411, 412, 413, 414, 415, 416, 417, 418, 419, 420, 421, 422, 423, 424, 425, 426, 427, 428, 429, 430, 431, 432, 433, 434, 435, 436, 437, 438}, arg2: true);
            }

            public override TriggerState Execute() {
                return new State벨라Script5Delay(context);
            }

            public override void OnExit() { }
        }

        private class State벨라Script5Delay : TriggerState {
            internal State벨라Script5Delay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "2", arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    return new State벨라Script5(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벨라Script5 : TriggerState {
            internal State벨라Script5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 301, arg2: true);
                context.SetSceneSkip(state: new State벨라이동2(context), arg2: "nextState");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetTimer(id: "1", arg2: 6);
                context.SetConversation(arg1: 2, arg2: 11000057, script: "$02000254_BF__SCENE01__7$", arg4: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State벨라Script6(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벨라Script6 : TriggerState {
            internal State벨라Script6(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "1", arg2: 4);
                context.SetConversation(arg1: 2, arg2: 11000057, script: "$02000254_BF__SCENE01__8$", arg4: 2);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State벨라이동2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벨라이동2 : TriggerState {
            internal State벨라이동2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetTimer(id: "1", arg2: 4);
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_2");
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State이펙트1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이펙트1 : TriggerState {
            internal State이펙트1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "1", arg2: 1);
                context.SetEffect(arg1: new[] {401}, arg2: true);
                context.DestroyMonster(arg1: new[] {102});
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State벨라Monster소환(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벨라Monster소환 : TriggerState {
            internal State벨라Monster소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "1", arg2: 3);
                context.CameraSelect(arg1: 303, arg2: true);
                context.CreateMonster(arg1: new[] {106});
                context.CreateMonster(arg1: new[] {103});
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State끝(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State끝 : TriggerState {
            internal State끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "1", arg2: 2);
                context.CameraSelectPath(pathIds: new[] {303}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State끝2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State끝2 : TriggerState {
            internal State끝2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 301, arg2: false);
                context.CameraSelect(arg1: 303, arg2: false);
                context.SetMesh(arg1: new[] {3002}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}