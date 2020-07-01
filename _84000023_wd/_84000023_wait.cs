namespace Maple2.Trigger._84000023_wd {
    public static class _84000023_wait {
        public class State초기화 : TriggerState {
            internal State초기화(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "Weddingceremonyfail", value: 0);
            }

            public override TriggerState Execute() {
                return new State시작_타이머설정(context);
            }

            public override void OnExit() { }
        }

        private class State시작_타이머설정 : TriggerState {
            internal State시작_타이머설정(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "4000", arg2: 2100, arg3: true, arg4: false);
            }

            public override TriggerState Execute() {
                return new State위치세팅(context);
            }

            public override void OnExit() { }
        }

        private class State위치세팅 : TriggerState {
            internal State위치세팅(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.WeddingMoveUser(entryType: "Guest", arg1: 84000023, arg2: new byte[] {22, 23}, arg3: 701);
            }

            public override TriggerState Execute() {
                if (context.WeddingEntryInField(entryType: "GroomBride", isInField: true)) {
                    return new State둘다입장(context);
                }

                if (context.TimeExpired(arg1: "4000")) {
                    return new State강퇴안내(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State위치돌림 : TriggerState {
            internal State위치돌림(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.WeddingMoveUser(entryType: "Guest", arg1: 84000023, arg2: new byte[] {22, 23}, arg3: 701);
            }

            public override TriggerState Execute() {
                return new State위치세팅(context);
            }

            public override void OnExit() { }
        }

        private class State대기01 : TriggerState {
            internal State대기01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 28400131, textId: 28400131);
            }

            public override TriggerState Execute() {
                if (context.WeddingEntryInField(entryType: "GroomBride", isInField: true)) {
                    return new State둘다입장(context);
                }

                if (context.TimeExpired(arg1: "4000")) {
                    return new State강퇴안내(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 28400131);
            }
        }

        private class State둘다입장 : TriggerState {
            internal State둘다입장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 28400133, textId: 28400133);
                context.SetUserValue(key: "StartWedding", value: 0);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "StartWedding") == 1) {
                    return new State결혼확인띄우기(context);
                }

                if (context.TimeExpired(arg1: "4000")) {
                    return new State강퇴안내(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 28400133);
            }
        }

        private class State결혼확인띄우기 : TriggerState {
            internal State결혼확인띄우기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.WeddingMutualAgree(agreeType: "startActing");
                context.SetUserValue(triggerId: 4002, key: "Weddingceremonystartsready", value: 1);
            }

            public override TriggerState Execute() {
                return new State결혼시작체크(context);
            }

            public override void OnExit() { }
        }

        private class State결혼시작체크 : TriggerState {
            internal State결혼시작체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WeddingEntryInField(entryType: "GroomBride", isInField: false)) {
                    return new State대기01(context);
                }

                if (context.WeddingMutualAgreeResult(agreeType: "startActing", success: true)) {
                    return new State결혼식연출진행중(context);
                }

                if (context.WeddingMutualAgreeResult(agreeType: "startActing", success: false)) {
                    return new State대기01(context);
                }

                if (context.TimeExpired(arg1: "4000")) {
                    return new State강퇴안내(context);
                }

                return null;
            }

            public override void OnExit() {
                context.WeddingMoveUser(entryType: "Guest", arg1: 84000023, arg2: new byte[] {22, 23}, arg3: 701);
            }
        }

        private class State강퇴안내 : TriggerState {
            internal State강퇴안내(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 28400132, textId: 28400132);
                context.WeddingBroken();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State강퇴(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State강퇴 : TriggerState {
            internal State강퇴(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 28400132);
                context.MoveUser(arg1: 0, arg2: 0);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class State결혼식연출진행중 : TriggerState {
            internal State결혼식연출진행중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 4001, key: "Weddingceremonystarts", value: 1);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Weddingceremonyfail") == 1) {
                    context.SetUserValue(key: "Weddingceremonyfail", value: 0);
                    return new State위치세팅(context);
                }

                if (context.WeddingHallState(hallState: "weddingComplete")) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}